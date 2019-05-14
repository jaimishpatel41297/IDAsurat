
var app = angular.module('Inquiry', []);
app.controller('InquiryController', function ($scope, $http, $window) {

    $scope.getCookie = function (cname) {
        var name = cname + "=";
        var decodedCookie = decodeURIComponent(document.cookie);
        var ca = decodedCookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {
                return c.substring(name.length, c.length);
            }
        }
        return "";
    }

    $(function () {
        debugger;
        $("[id$=txtSearch]").autocomplete({
            source: function (request, response) {
                $scope.SEARCH_USER.VMESSAGE = '';
                $.ajax({
                    url: "AddInquiry.aspx/GetCustomers",
                    data: "{ 'prefix': '" + request.term + "'}",
                    dataType: "json",
                    type: "POST",
                    contentType: "application/json; charset=utf-8",

                    success: function (data) {

                        response($.map(data.d, function (item) {

                            return {
                                singledata: item,
                                label: item,
                                Mobile: item.split(' - ')[0]
                            }
                        }))
                    },
                    error: function (response) {
                        alert(response.responseText);
                    },
                    failure: function (response) {

                        alert(response.responseText);
                    }
                });
            },
            select: function (e, i) {
                //$scope.MOBILE = i.item.Mobile;

                $scope.SEARCH_USER.MOBILE = i.item.Mobile;
                $scope.SEARCH_USER.MNO = i.item.Mobile;

                $scope.$apply();
                // $("[id$=txtSearch]").val(i.item.val);
            },
            minLength: 1
        });
    });


    $scope.GetSearch = function (searchuser) {
        debugger;
        var id = $scope.getCookie("UserId");
        if (searchuser.MNO) {

        }
        else {
            $scope.SEARCH_USER.MESSAGE = "Not Found !";
            return;
        }

        if (searchuser.MNO == '') {
            $scope.SEARCH_USER.MESSAGE = "Can't be blank !";
            return;
        } else {
            $scope.SEARCH_USER.MESSAGE = "";
        }

        var data = $.param({
            ACTION: "getsearchdata",
            Mobile: searchuser.MNO,
            Id: id
        });
        var config = {
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded;charset=utf-8;'
                //   'Cross'
            }
        }
        $http({

            method: 'POST',
            url: '/AppService.asmx/InquirySearch',
            data: data,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },

        }).then(function (success) {


            if (success.data.ERROR_STATUS == false) {

                $("#InfoModal").modal("show");

                $scope.userlist = success.data.getuserdata[0];

                $scope.id = success.data.getuserdata[0].Id;
                $scope.Name = success.data.getuserdata[0].Name;
                $scope.Mobile = success.data.getuserdata[0].MobileNo;
                $scope.Discount = success.data.getuserdata[0].Discount;
                $scope.IDate = success.data.getuserdata[0].InquiryDate;
                $scope.FDate = success.data.getuserdata[0].FollowUpdate;
                $scope.CName = success.data.getuserdata[0].CName;
                $scope.RName = success.data.getuserdata[0].RName;


                //console.log($scope.userlist);
            } else {
                $scope.SEARCH_USER.MESSAGE = 'Mobile No Does Not Exists';

            }

            $scope.SEARCH_USER.MNO = '';

        }, function (error) {
            console.log(error);
            window.alert('Failed To Load');

        });
    };
});