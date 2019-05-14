using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for FeesReceipt
/// </summary>
public class FeesReceipt : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
	private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRLabel xrLabel14;
    private XRLabel xrLabel15;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRShape xrShape2;
    private XRLabel xrLabel21; 
    private XRLabel xrLabel18;
    private XRLabel xrLabel16;
    private XRShape xrShape3;
    private XRPictureBox xrPictureBox2;
    private XRLabel xrLabel27;
    private XRLabel xrLabel26;
    private XRLabel xrLabel25;
    private XRLabel xrLabel24;
    private XRLabel xrLabel22;
    private XRLabel xrLabel7;
    private XRLabel xrLabel4;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRShape xrShape1;
    private XRLabel xrLabel1;
    private XRPictureBox xrPictureBox1;
    private XRLine xrLine1;
    private XRLine xrLine2;
    private XRCheckBox xrCheckBox5;
    private XRCheckBox xrCheckBox4;
    private XRCheckBox xrCheckBox3;
    private XRCheckBox xrCheckBox2;
    private XRCheckBox xrCheckBox1;
    private XRShape xrShape4;
    private XRLabel xrLabel28;
    private XRShape xrShape5;
    private XRShape xrShape6;
    private XRLabel xrLabel30;
    private XRLabel xrLabel29;
    private XRLine xrLine6;
    private XRLine xrLine5;
    private XRLine xrLine4;
    private XRLine xrLine3;
    private XRLine xrLine7;
    private XRLine xrLine8;
    private XRLine xrLine10;
    private XRLine xrLine9;
    private XRLine xrLine11;
    private XRLabel xrLabel31;
    private XRShape xrShape7;
    private XRShape xrShape8;
    private XRShape xrShape9;
    private XRLabel xrLabel32;
    private XRLabel xrLabel33;
    private XRLabel xrLabel34;
    private XRLabel xrLabel35;
    private XRLabel xrLabel36;
    private XRLabel xrLabel37;
    private XRLabel xrLabel38;
    private XRLabel xrLabel39;
    private XRLabel xrLabel40;
    private XRLabel xrLabel41;
    private XRLabel xrLabel42;
    private XRLine xrLine12;
    private XRLine xrLine13;
    private XRPictureBox xrPictureBox3;
    private XRLabel xrLabel43;
    private XRShape xrShape10;
    private XRLabel xrLabel44;
    private XRLabel xrLabel45;
    private XRLabel xrLabel46;
    private XRLabel xrLabel49;
    private XRLabel xrLabel50;
    private XRLabel xrLabel51;
    private XRLabel xrLabel52;
    private XRLabel xrLabel53;
    private XRLabel xrLabel54;
    private XRPictureBox xrPictureBox4;
    private XRShape xrShape11;
    private XRLabel xrLabel55;
    private XRShape xrShape12;
    private XRCheckBox xrCheckBox7;
    private XRCheckBox xrCheckBox8;
    private XRCheckBox xrCheckBox9;
    private XRCheckBox xrCheckBox10;
    private XRCheckBox xrCheckBox11;
    private XRLabel xrLabel56;
    private XRLabel xrLabel57;
    private XRLine xrLine14;
    private XRLine xrLine15;
    private XRLine xrLine16;
    private XRLine xrLine17;
    private XRLine xrLine18;
    private XRLine xrLine19;
    private XRLine xrLine20;
    private XRLine xrLine21;
    private XRLine xrLine22;
    private XRLabel xrLabel58;
    private XRShape xrShape13;
    private XRLabel xrLabel17;
    private XRLabel xrLabel19;
    private XRShape xrShape14;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel20;
    private XRLabel xrLabel23;
    private XRLabel xrLabel59;
    private XRLabel xrLabel60;
    private XRLabel xrLabel62;
    private XRLabel xrLabel61;
    private XRLabel xrLabel63;
    private XRLabel xrLabel64;
    private XRLabel xrLabel65;
    private XRLabel xrLabel69;
    private XRLabel xrLabel70;
    private XRLabel xrLabel71;
    private XRLabel xrLabel72;
    private XRLabel xrLabel66;
    private XRLabel xrLabel67;
    private XRLabel xrLabel68;
    private XRLabel xrLabel74;
    private XRLabel xrLabel73;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

	public FeesReceipt()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
            string resourceFileName = "FeesReceipt.resx";
            System.Resources.ResourceManager resources = global::Resources.FeesReceipt.ResourceManager;
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle14 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle1 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle2 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle3 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle4 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle5 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle6 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle7 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle8 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle9 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle10 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle11 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle12 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle13 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape8 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine12 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine13 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPictureBox3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape10 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrShape11 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape12 = new DevExpress.XtraReports.UI.XRShape();
            this.xrCheckBox8 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox9 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox10 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox11 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine14 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine15 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine16 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine17 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine18 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine19 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine20 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine21 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine22 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine10 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine9 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCheckBox5 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox4 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox3 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox2 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrShape4 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape3 = new DevExpress.XtraReports.UI.XRShape();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape5 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape2 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape13 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape6 = new DevExpress.XtraReports.UI.XRShape();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCheckBox7 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrShape14 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape7 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape9 = new DevExpress.XtraReports.UI.XRShape();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel74,
            this.xrLabel73,
            this.xrLabel69,
            this.xrLabel70,
            this.xrLabel71,
            this.xrLabel72,
            this.xrLabel66,
            this.xrLabel67,
            this.xrLabel68,
            this.xrLabel64,
            this.xrLabel65,
            this.xrLabel61,
            this.xrLabel63,
            this.xrLabel62,
            this.xrLabel60,
            this.xrLabel59,
            this.xrLabel23,
            this.xrLabel20,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel19,
            this.xrLabel17,
            this.xrLabel32,
            this.xrLabel33,
            this.xrLabel34,
            this.xrLabel35,
            this.xrLabel36,
            this.xrLabel37,
            this.xrLabel38,
            this.xrLabel39,
            this.xrLabel41,
            this.xrLabel42,
            this.xrLine12,
            this.xrLine13,
            this.xrPictureBox3,
            this.xrLabel43,
            this.xrShape10,
            this.xrLabel44,
            this.xrLabel45,
            this.xrLabel46,
            this.xrLabel49,
            this.xrLabel50,
            this.xrLabel51,
            this.xrLabel52,
            this.xrLabel53,
            this.xrLabel54,
            this.xrPictureBox4,
            this.xrShape11,
            this.xrLabel55,
            this.xrShape12,
            this.xrCheckBox8,
            this.xrCheckBox9,
            this.xrCheckBox10,
            this.xrCheckBox11,
            this.xrLabel56,
            this.xrLabel57,
            this.xrLine14,
            this.xrLine15,
            this.xrLine16,
            this.xrLine17,
            this.xrLine18,
            this.xrLine19,
            this.xrLine20,
            this.xrLine21,
            this.xrLine22,
            this.xrLabel58,
            this.xrLabel31,
            this.xrLine11,
            this.xrLine10,
            this.xrLine9,
            this.xrLine8,
            this.xrLine7,
            this.xrLine6,
            this.xrLine5,
            this.xrLine4,
            this.xrLine3,
            this.xrLabel30,
            this.xrLabel29,
            this.xrCheckBox5,
            this.xrCheckBox4,
            this.xrCheckBox3,
            this.xrCheckBox2,
            this.xrCheckBox1,
            this.xrShape4,
            this.xrLabel28,
            this.xrShape3,
            this.xrPictureBox2,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel22,
            this.xrLabel7,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrShape1,
            this.xrLabel1,
            this.xrPictureBox1,
            this.xrLine1,
            this.xrLine2,
            this.xrLabel21,
            this.xrLabel18,
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrShape5,
            this.xrShape2,
            this.xrShape13,
            this.xrShape6,
            this.xrLabel40,
            this.xrCheckBox7,
            this.xrShape14,
            this.xrShape7,
            this.xrShape9,
            this.xrShape8});
            this.Detail.HeightF = 3369.208F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel62
            // 
            this.xrLabel62.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Fe")});
            this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(425.75F, 410.9166F);
            this.xrLabel62.Name = "xrLabel62";
            this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel62.SizeF = new System.Drawing.SizeF(122.8752F, 23F);
            // 
            // xrLabel60
            // 
            this.xrLabel60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Bank")});
            this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(517.6252F, 346.0416F);
            this.xrLabel60.Name = "xrLabel60";
            this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel60.SizeF = new System.Drawing.SizeF(75.77679F, 23F);
            // 
            // xrLabel59
            // 
            this.xrLabel59.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Date", "{0:dd-MMM-yy}")});
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(497.8752F, 314.5833F);
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(90.52682F, 23F);
            // 
            // xrLabel23
            // 
            this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Bank")});
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(95.87513F, 341.5833F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLabel20
            // 
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Num")});
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(165.6669F, 315.5833F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.FeeDate", "{0:dd-MMM-yy}")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(699.1661F, 104.2917F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(95.62549F, 23F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Id", "{0}")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(719.1663F, 79.29167F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(95.62543F, 23.87498F);
            // 
            // xrLabel19
            // 
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Fee")});
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(100.6251F, 817.4586F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLabel17
            // 
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Fee")});
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(100.6251F, 217.125F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrShape8
            // 
            this.xrShape8.LocationFloat = new DevExpress.Utils.PointFloat(20.66682F, 905.9168F);
            this.xrShape8.Name = "xrShape8";
            this.xrShape8.Shape = shapeRectangle14;
            this.xrShape8.SizeF = new System.Drawing.SizeF(595.8334F, 69.29169F);
            // 
            // xrLabel32
            // 
            this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(20.66682F, 785.0002F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(40.625F, 21F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.Text = "From";
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(21.66681F, 815.4586F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(55.20834F, 20.99998F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.Text = "Rupees";
            // 
            // xrLabel34
            // 
            this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(21.66681F, 846.9169F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(111.0417F, 21F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.Text = "Against Bill No";
            // 
            // xrLabel35
            // 
            this.xrLabel35.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(22.6668F, 879.2501F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(73.95834F, 21F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.Text = "On A/c of";
            // 
            // xrLabel36
            // 
            this.xrLabel36.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(25.66681F, 914.9168F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(128.7501F, 21F);
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.Text = "Cheque/Draft No.";
            // 
            // xrLabel37
            // 
            this.xrLabel37.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(26.6668F, 942.3751F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(50.20835F, 21F);
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.Text = "Bank";
            // 
            // xrLabel38
            // 
            this.xrLabel38.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(436.1668F, 914.9168F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(36.45831F, 21F);
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.Text = "Date";
            // 
            // xrLabel39
            // 
            this.xrLabel39.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(435.1668F, 944.3751F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(55.20834F, 21F);
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.Text = "Branch";
            // 
            // xrLabel41
            // 
            this.xrLabel41.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(649.4582F, 832.0836F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(66.9585F, 21F);
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.Text = "Cheque";
            // 
            // xrLabel42
            // 
            this.xrLabel42.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(649.4582F, 858.0836F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(66.9585F, 21F);
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.Text = "Draft";
            // 
            // xrLine12
            // 
            this.xrLine12.LocationFloat = new DevExpress.Utils.PointFloat(680.9162F, 717.1668F);
            this.xrLine12.Name = "xrLine12";
            this.xrLine12.SizeF = new System.Drawing.SizeF(131.8749F, 3.083313F);
            // 
            // xrLine13
            // 
            this.xrLine13.LocationFloat = new DevExpress.Utils.PointFloat(678.916F, 690.6251F);
            this.xrLine13.Name = "xrLine13";
            this.xrLine13.SizeF = new System.Drawing.SizeF(131.8751F, 5.625061F);
            // 
            // xrPictureBox3
            // 
            this.xrPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox3.Image")));
            this.xrPictureBox3.LocationFloat = new DevExpress.Utils.PointFloat(4.791685F, 612.3335F);
            this.xrPictureBox3.Name = "xrPictureBox3";
            this.xrPictureBox3.SizeF = new System.Drawing.SizeF(122.9167F, 87.5F);
            this.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel43
            // 
            this.xrLabel43.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(4.791685F, 699.5002F);
            this.xrLabel43.Multiline = true;
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(122.9167F, 44.16667F);
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.Text = "Inception\r\nDesign Academy\r\n";
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrShape10
            // 
            this.xrShape10.LocationFloat = new DevExpress.Utils.PointFloat(128.1251F, 617.3335F);
            this.xrShape10.Name = "xrShape10";
            shapeRectangle1.Fillet = 25;
            this.xrShape10.Shape = shapeRectangle1;
            this.xrShape10.SizeF = new System.Drawing.SizeF(506.6666F, 121.6667F);
            // 
            // xrLabel44
            // 
            this.xrLabel44.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(637.7914F, 615.3335F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(185F, 63.625F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.Text = "RECEIPT";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel45
            // 
            this.xrLabel45.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(638.7916F, 674.6252F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(43.12457F, 23F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            this.xrLabel45.Text = "No";
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel46
            // 
            this.xrLabel46.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(638.7916F, 698.5002F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(43.12457F, 23F);
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.StylePriority.UseTextAlignment = false;
            this.xrLabel46.Text = "Date";
            this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel49
            // 
            this.xrLabel49.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(11.79176F, 742.6667F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(629.9999F, 23F);
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.Text = "Received payment with thanks as per following details. ";
            // 
            // xrLabel50
            // 
            this.xrLabel50.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(648.4583F, 908.9169F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(111.0417F, 21F);
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.Text = "Full";
            // 
            // xrLabel51
            // 
            this.xrLabel51.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(648.4583F, 933.9169F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(100F, 21F);
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.Text = "Part";
            // 
            // xrLabel52
            // 
            this.xrLabel52.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(651.4583F, 883.9169F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(100F, 21F);
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.StylePriority.UseTextAlignment = false;
            this.xrLabel52.Text = "Payment";
            this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel53
            // 
            this.xrLabel53.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(71.41679F, 1048.667F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(128.7501F, 21F);
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.Text = "Authorished by";
            // 
            // xrLabel54
            // 
            this.xrLabel54.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(319.0007F, 1033.25F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(256.9984F, 21F);
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.Text = "N.B subject to Realisation of Cheque";
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.ImageUrl = "~\\Admin\\plugins\\images\\123.png";
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(337.2916F, 1006.834F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(30.20834F, 24.41656F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrShape11
            // 
            this.xrShape11.LocationFloat = new DevExpress.Utils.PointFloat(367.4999F, 1006.917F);
            this.xrShape11.Name = "xrShape11";
            this.xrShape11.Shape = shapeRectangle2;
            this.xrShape11.SizeF = new System.Drawing.SizeF(162.6659F, 24.58328F);
            // 
            // xrLabel55
            // 
            this.xrLabel55.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(648.7914F, 1048.667F);
            this.xrLabel55.Name = "xrLabel55";
            this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel55.SizeF = new System.Drawing.SizeF(128.7501F, 21F);
            this.xrLabel55.StylePriority.UseFont = false;
            this.xrLabel55.StylePriority.UseTextAlignment = false;
            this.xrLabel55.Text = "Receiver\'s Sign";
            this.xrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrShape12
            // 
            this.xrShape12.LocationFloat = new DevExpress.Utils.PointFloat(647.7914F, 994.9168F);
            this.xrShape12.Name = "xrShape12";
            this.xrShape12.Shape = shapeRectangle3;
            this.xrShape12.SizeF = new System.Drawing.SizeF(128.7501F, 53.75F);
            // 
            // xrCheckBox8
            // 
            this.xrCheckBox8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("CheckState", null, "CustomSqlQuery.Pay1")});
            this.xrCheckBox8.LocationFloat = new DevExpress.Utils.PointFloat(716.4166F, 831.1668F);
            this.xrCheckBox8.Name = "xrCheckBox8";
            this.xrCheckBox8.SizeF = new System.Drawing.SizeF(22.91663F, 21.00003F);
            // 
            // xrCheckBox9
            // 
            this.xrCheckBox9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("CheckState", null, "CustomSqlQuery.Pay2")});
            this.xrCheckBox9.LocationFloat = new DevExpress.Utils.PointFloat(716.5418F, 858.4586F);
            this.xrCheckBox9.Name = "xrCheckBox9";
            this.xrCheckBox9.SizeF = new System.Drawing.SizeF(22.91663F, 21.00003F);
            // 
            // xrCheckBox10
            // 
            this.xrCheckBox10.LocationFloat = new DevExpress.Utils.PointFloat(719.5416F, 907.9168F);
            this.xrCheckBox10.Name = "xrCheckBox10";
            this.xrCheckBox10.SizeF = new System.Drawing.SizeF(22.91663F, 21.00003F);
            // 
            // xrCheckBox11
            // 
            this.xrCheckBox11.LocationFloat = new DevExpress.Utils.PointFloat(720.5415F, 931.9167F);
            this.xrCheckBox11.Name = "xrCheckBox11";
            this.xrCheckBox11.SizeF = new System.Drawing.SizeF(22.91663F, 21.00003F);
            // 
            // xrLabel56
            // 
            this.xrLabel56.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(405.501F, 623.3335F);
            this.xrLabel56.Name = "xrLabel56";
            this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel56.SizeF = new System.Drawing.SizeF(229.2906F, 21F);
            this.xrLabel56.StylePriority.UseFont = false;
            this.xrLabel56.Text = "CONTACT: +91 76219 89503";
            // 
            // xrLabel57
            // 
            this.xrLabel57.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(142.7084F, 713.2502F);
            this.xrLabel57.Name = "xrLabel57";
            this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel57.SizeF = new System.Drawing.SizeF(507.0833F, 21F);
            this.xrLabel57.StylePriority.UseFont = false;
            this.xrLabel57.Text = "207-12,J9 HIGH STREET NEAR LP SAVANI SCHOOL ,CANAL ROAD,VESU";
            // 
            // xrLine14
            // 
            this.xrLine14.LocationFloat = new DevExpress.Utils.PointFloat(59.29182F, 801.0002F);
            this.xrLine14.Name = "xrLine14";
            this.xrLine14.SizeF = new System.Drawing.SizeF(573.4999F, 2F);
            // 
            // xrLine15
            // 
            this.xrLine15.LocationFloat = new DevExpress.Utils.PointFloat(74.87514F, 831.0836F);
            this.xrLine15.Name = "xrLine15";
            this.xrLine15.SizeF = new System.Drawing.SizeF(557.9166F, 2F);
            // 
            // xrLine16
            // 
            this.xrLine16.LocationFloat = new DevExpress.Utils.PointFloat(130.7086F, 860.9169F);
            this.xrLine16.Name = "xrLine16";
            this.xrLine16.SizeF = new System.Drawing.SizeF(501.0832F, 4F);
            // 
            // xrLine17
            // 
            this.xrLine17.LocationFloat = new DevExpress.Utils.PointFloat(93.62513F, 891.5834F);
            this.xrLine17.Name = "xrLine17";
            this.xrLine17.SizeF = new System.Drawing.SizeF(539.1666F, 7.666779F);
            // 
            // xrLine18
            // 
            this.xrLine18.LocationFloat = new DevExpress.Utils.PointFloat(147.4169F, 925.9168F);
            this.xrLine18.Name = "xrLine18";
            this.xrLine18.SizeF = new System.Drawing.SizeF(278.3333F, 6.000031F);
            // 
            // xrLine19
            // 
            this.xrLine19.LocationFloat = new DevExpress.Utils.PointFloat(65.41682F, 1048.667F);
            this.xrLine19.Name = "xrLine19";
            this.xrLine19.SizeF = new System.Drawing.SizeF(128.7501F, 2F);
            // 
            // xrLine20
            // 
            this.xrLine20.LocationFloat = new DevExpress.Utils.PointFloat(70.87515F, 956.3751F);
            this.xrLine20.Name = "xrLine20";
            this.xrLine20.SizeF = new System.Drawing.SizeF(267F, 2F);
            // 
            // xrLine21
            // 
            this.xrLine21.LocationFloat = new DevExpress.Utils.PointFloat(471.6252F, 925.9168F);
            this.xrLine21.Name = "xrLine21";
            this.xrLine21.SizeF = new System.Drawing.SizeF(138F, 5.999969F);
            // 
            // xrLine22
            // 
            this.xrLine22.LocationFloat = new DevExpress.Utils.PointFloat(487.3752F, 956.3751F);
            this.xrLine22.Name = "xrLine22";
            this.xrLine22.SizeF = new System.Drawing.SizeF(123F, 6F);
            // 
            // xrLabel58
            // 
            this.xrLabel58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.StudentName")});
            this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(79.87516F, 786.0002F);
            this.xrLabel58.Name = "xrLabel58";
            this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel58.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLabel31
            // 
            this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.StudentName")});
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(77.87488F, 186.5417F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLine11
            // 
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(487.6252F, 358.0416F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(123F, 6F);
            // 
            // xrLine10
            // 
            this.xrLine10.LocationFloat = new DevExpress.Utils.PointFloat(471.8752F, 327.5833F);
            this.xrLine10.Name = "xrLine10";
            this.xrLine10.SizeF = new System.Drawing.SizeF(138F, 5.999969F);
            // 
            // xrLine9
            // 
            this.xrLine9.LocationFloat = new DevExpress.Utils.PointFloat(72.1252F, 356.0416F);
            this.xrLine9.Name = "xrLine9";
            this.xrLine9.SizeF = new System.Drawing.SizeF(267F, 2F);
            // 
            // xrLine8
            // 
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(67.41679F, 448.3333F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(128.7501F, 2F);
            // 
            // xrLine7
            // 
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(149.6669F, 326.5833F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(278.3333F, 6.000031F);
            // 
            // xrLine6
            // 
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(93.87517F, 291.2499F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(539.1666F, 7.666779F);
            // 
            // xrLine5
            // 
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(130.9586F, 260.5834F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(501.0832F, 4F);
            // 
            // xrLine4
            // 
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(75.1252F, 230.75F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(557.9166F, 2F);
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(59.54187F, 200.6667F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(573.4999F, 2F);
            // 
            // xrLabel30
            // 
            this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(142.9584F, 112.9167F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(507.0833F, 21F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.Text = "207-12,J9 HIGH STREET NEAR LP SAVANI SCHOOL ,CANAL ROAD,VESU";
            // 
            // xrLabel29
            // 
            this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(405.7511F, 23.00001F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(229.2906F, 21F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.Text = "CONTACT: +91 76219 89503";
            // 
            // xrCheckBox5
            // 
            this.xrCheckBox5.LocationFloat = new DevExpress.Utils.PointFloat(720.7917F, 331.5833F);
            this.xrCheckBox5.Name = "xrCheckBox5";
            this.xrCheckBox5.SizeF = new System.Drawing.SizeF(22.91663F, 21.00003F);
            // 
            // xrCheckBox4
            // 
            this.xrCheckBox4.LocationFloat = new DevExpress.Utils.PointFloat(718.7917F, 307.5833F);
            this.xrCheckBox4.Name = "xrCheckBox4";
            this.xrCheckBox4.SizeF = new System.Drawing.SizeF(22.91663F, 21.00003F);
            // 
            // xrCheckBox3
            // 
            this.xrCheckBox3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("CheckState", null, "CustomSqlQuery.Pay2")});
            this.xrCheckBox3.LocationFloat = new DevExpress.Utils.PointFloat(718.7919F, 258.125F);
            this.xrCheckBox3.Name = "xrCheckBox3";
            this.xrCheckBox3.SizeF = new System.Drawing.SizeF(22.91663F, 21.00003F);
            // 
            // xrCheckBox2
            // 
            this.xrCheckBox2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("CheckState", null, "CustomSqlQuery.Pay1")});
            this.xrCheckBox2.LocationFloat = new DevExpress.Utils.PointFloat(718.6667F, 230.8333F);
            this.xrCheckBox2.Name = "xrCheckBox2";
            this.xrCheckBox2.SizeF = new System.Drawing.SizeF(22.91663F, 21.00003F);
            // 
            // xrCheckBox1
            // 
            this.xrCheckBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("CheckState", null, "CustomSqlQuery.Pay")});
            this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(718.4166F, 203.75F);
            this.xrCheckBox1.Name = "xrCheckBox1";
            this.xrCheckBox1.SizeF = new System.Drawing.SizeF(13.04169F, 24.00002F);
            // 
            // xrShape4
            // 
            this.xrShape4.LocationFloat = new DevExpress.Utils.PointFloat(648.0415F, 394.5833F);
            this.xrShape4.Name = "xrShape4";
            this.xrShape4.Shape = shapeRectangle4;
            this.xrShape4.SizeF = new System.Drawing.SizeF(128.7501F, 53.75F);
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(649.0415F, 448.3333F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(128.7501F, 21F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Receiver\'s Sign";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrShape3
            // 
            this.xrShape3.LocationFloat = new DevExpress.Utils.PointFloat(367.75F, 406.5833F);
            this.xrShape3.Name = "xrShape3";
            this.xrShape3.Shape = shapeRectangle5;
            this.xrShape3.SizeF = new System.Drawing.SizeF(162.6659F, 24.58328F);
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.ImageUrl = "~\\Admin\\plugins\\images\\123.png";
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(337.5417F, 406.5F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(30.20834F, 24.41656F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(319.2508F, 432.9166F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(256.9984F, 21F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.Text = "N.B subject to Realisation of Cheque";
            // 
            // xrLabel26
            // 
            this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(72.66685F, 448.3334F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(111.0418F, 20.99997F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "Authorished by";
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(651.7084F, 283.5834F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(100F, 21F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Payment";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(648.7084F, 333.5834F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(100F, 21F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.Text = "Part";
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(648.7084F, 308.5834F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(111.0417F, 21F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.Text = "Full";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(12.04181F, 142.3333F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(629.9999F, 23F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "Received payment with thanks as per following details. ";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(639.0416F, 98.16666F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(43.12457F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Date";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(639.0416F, 74.29168F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(43.12457F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "No";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(638.0416F, 15F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(185F, 63.625F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "RECEIPT";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrShape1
            // 
            this.xrShape1.LocationFloat = new DevExpress.Utils.PointFloat(128.3751F, 17F);
            this.xrShape1.Name = "xrShape1";
            shapeRectangle6.Fillet = 25;
            this.xrShape1.Shape = shapeRectangle6;
            this.xrShape1.SizeF = new System.Drawing.SizeF(506.6666F, 121.6667F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(5.041733F, 99.16666F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(122.9167F, 44.16667F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Inception\r\nDesign Academy\r\n";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(5.041733F, 12F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(122.9167F, 87.5F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(678.1661F, 81.91665F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(131.8751F, 23F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(678.1664F, 106.9167F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(131.8749F, 23F);
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(649.7084F, 257.75F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(111.0417F, 21F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.Text = "Draft";
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(649.7084F, 231.75F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(100F, 21.00002F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.Text = "Cheque";
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(648.7084F, 204.75F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(100F, 21F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.Text = "Cash";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(435.4169F, 346.0416F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(55.20834F, 21F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "Branch";
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(436.4169F, 316.5833F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(36.45831F, 21F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "Date";
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(26.91685F, 342.0416F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(50.20835F, 21F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "Bank";
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(25.91686F, 314.5833F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(128.7501F, 21F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "Cheque/Draft No.";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(22.91685F, 278.9166F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(73.95834F, 21F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "On A/c of";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(21.91686F, 246.5834F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(111.0417F, 21F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "Against Bill No";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(21.91686F, 215.125F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(55.20834F, 20.99998F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Rupees";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(20.91687F, 184.6667F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(40.625F, 21F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "From";
            // 
            // xrShape5
            // 
            this.xrShape5.LocationFloat = new DevExpress.Utils.PointFloat(647.0415F, 199.6667F);
            this.xrShape5.Name = "xrShape5";
            this.xrShape5.Shape = shapeRectangle7;
            this.xrShape5.SizeF = new System.Drawing.SizeF(128.7501F, 160.9166F);
            // 
            // xrShape2
            // 
            this.xrShape2.LocationFloat = new DevExpress.Utils.PointFloat(9.00001F, 171.6667F);
            this.xrShape2.Name = "xrShape2";
            shapeRectangle8.Fillet = 21;
            this.xrShape2.Shape = shapeRectangle8;
            this.xrShape2.SizeF = new System.Drawing.SizeF(781.6663F, 222.9167F);
            // 
            // xrShape13
            // 
            this.xrShape13.LocationFloat = new DevExpress.Utils.PointFloat(2.208638F, 0F);
            this.xrShape13.Name = "xrShape13";
            this.xrShape13.Shape = shapeRectangle9;
            this.xrShape13.SizeF = new System.Drawing.SizeF(822.7914F, 485.5F);
            // 
            // xrShape6
            // 
            this.xrShape6.LocationFloat = new DevExpress.Utils.PointFloat(20.66681F, 307.5833F);
            this.xrShape6.Name = "xrShape6";
            this.xrShape6.Shape = shapeRectangle10;
            this.xrShape6.SizeF = new System.Drawing.SizeF(595.8334F, 69.29169F);
            // 
            // xrLabel40
            // 
            this.xrLabel40.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(648.4583F, 805.0836F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(51.04163F, 21F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.Text = "Cash";
            // 
            // xrCheckBox7
            // 
            this.xrCheckBox7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("CheckState", null, "CustomSqlQuery.Pay")});
            this.xrCheckBox7.LocationFloat = new DevExpress.Utils.PointFloat(715.4166F, 805.0836F);
            this.xrCheckBox7.Name = "xrCheckBox7";
            this.xrCheckBox7.SizeF = new System.Drawing.SizeF(13.04169F, 22F);
            // 
            // xrShape14
            // 
            this.xrShape14.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 612.3335F);
            this.xrShape14.Name = "xrShape14";
            this.xrShape14.Shape = shapeRectangle11;
            this.xrShape14.SizeF = new System.Drawing.SizeF(822.7914F, 485.5F);
            // 
            // xrShape7
            // 
            this.xrShape7.LocationFloat = new DevExpress.Utils.PointFloat(8.74996F, 772.0002F);
            this.xrShape7.Name = "xrShape7";
            shapeRectangle12.Fillet = 21;
            this.xrShape7.Shape = shapeRectangle12;
            this.xrShape7.SizeF = new System.Drawing.SizeF(781.6663F, 222.9167F);
            // 
            // xrShape9
            // 
            this.xrShape9.LocationFloat = new DevExpress.Utils.PointFloat(646.7913F, 800.0002F);
            this.xrShape9.Name = "xrShape9";
            this.xrShape9.Shape = shapeRectangle13;
            this.xrShape9.SizeF = new System.Drawing.SizeF(128.7501F, 160.9166F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "IDASurat";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "CustomSqlQuery";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrLabel63
            // 
            this.xrLabel63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Num")});
            this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(163.6669F, 914.9169F);
            this.xrLabel63.Name = "xrLabel63";
            this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel63.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLabel61
            // 
            this.xrLabel61.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Bank")});
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(95.87515F, 942.3751F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLabel64
            // 
            this.xrLabel64.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Bank")});
            this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(80.62511F, 1542.167F);
            this.xrLabel64.Name = "xrLabel64";
            this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel64.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLabel65
            // 
            this.xrLabel65.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Fe")});
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(427.5F, 1011.708F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(122.8752F, 23F);
            // 
            // xrLabel66
            // 
            this.xrLabel66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Bank")});
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(76.66685F, 2143.333F);
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLabel67
            // 
            this.xrLabel67.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Fe")});
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(372.5417F, 1614.875F);
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.SizeF = new System.Drawing.SizeF(122.8752F, 23F);
            // 
            // xrLabel68
            // 
            this.xrLabel68.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Date", "{0:dd-MMM-yy}")});
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(493.9169F, 914.75F);
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(90.52682F, 23F);
            // 
            // xrLabel69
            // 
            this.xrLabel69.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Bank")});
            this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(74.66685F, 2745.167F);
            this.xrLabel69.Name = "xrLabel69";
            this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel69.SizeF = new System.Drawing.SizeF(231.25F, 23F);
            // 
            // xrLabel70
            // 
            this.xrLabel70.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Fe")});
            this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(370.5417F, 2216.708F);
            this.xrLabel70.Name = "xrLabel70";
            this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel70.SizeF = new System.Drawing.SizeF(122.8752F, 23F);
            // 
            // xrLabel71
            // 
            this.xrLabel71.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Date", "{0:dd-MMM-yy}")});
            this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(469.9169F, 1517.583F);
            this.xrLabel71.Name = "xrLabel71";
            this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel71.SizeF = new System.Drawing.SizeF(90.52682F, 23F);
            // 
            // xrLabel72
            // 
            this.xrLabel72.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Bank")});
            this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(509.6252F, 944.8749F);
            this.xrLabel72.Name = "xrLabel72";
            this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel72.SizeF = new System.Drawing.SizeF(75.77679F, 23F);
            // 
            // xrLabel73
            // 
            this.xrLabel73.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.Id", "{0}")});
            this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(720.1661F, 676.7501F);
            this.xrLabel73.Name = "xrLabel73";
            this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel73.SizeF = new System.Drawing.SizeF(95.62543F, 23.87498F);
            // 
            // xrLabel74
            // 
            this.xrLabel74.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomSqlQuery.FeeDate", "{0:dd-MMM-yy}")});
            this.xrLabel74.LocationFloat = new DevExpress.Utils.PointFloat(701.8745F, 703.2502F);
            this.xrLabel74.Name = "xrLabel74";
            this.xrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel74.SizeF = new System.Drawing.SizeF(95.62549F, 23F);
            // 
            // FeesReceipt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "CustomSqlQuery";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(0, 2, 0, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    //private void xrLabel61_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    //{
    //    if (xrLabel61.Text == "Cash")
    //    {
    //        xrCheckBox1.Checked = true;
    //        xrCheckBox1.CheckState = Checked;
    //        xrCheckBox2.Checked = false;
    //        xrCheckBox3.Checked = false;

    //        xrCheckBox7.Checked = true;
    //        xrCheckBox8.Checked = false;
    //        xrCheckBox9.Checked = false;
    //    }
    //    else if (xrLabel61.Text == "Cheque")
    //    {
    //        xrCheckBox1.Checked = false;
    //        xrCheckBox2.Checked = true;
    //        xrCheckBox3.Checked = false;

    //        xrCheckBox7.Checked = false;
    //        xrCheckBox8.Checked = true;
    //        xrCheckBox9.Checked = false;
    //    }
    //    else if (xrLabel61.Text == "Draft")
    //    {
    //        xrCheckBox1.Checked = false;
    //        xrCheckBox2.Checked = false;
    //        xrCheckBox3.Checked = true;

    //        xrCheckBox7.Checked = false;
    //        xrCheckBox8.Checked = false;
    //        xrCheckBox9.Checked = true;
    //    }
    //}

    //public System.Windows.Forms.CheckState Checked { get; set; }
}
