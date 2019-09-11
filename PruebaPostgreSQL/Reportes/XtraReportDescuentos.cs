using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReportDescuentos
/// </summary>
public class XtraReportDescuentos : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
    private XRControlStyle Title;
    private XRControlStyle DetailCaption1;
    private XRControlStyle DetailData1;
    private XRControlStyle DetailData3_Odd;
    private XRControlStyle PageInfo;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private XRPageInfo pageInfo1;
    private XRPageInfo pageInfo2;
    private ReportHeaderBand ReportHeader;
    private XRLabel label1;
    private GroupHeaderBand GroupHeader1;
    private XRTable table1;
    private XRTableRow tableRow1;
    private XRTableCell tableCell1;
    private XRTableCell tableCell2;
    private XRTableCell tableCell3;
    private XRTableCell tableCell4;
    private XRTableCell tableCell5;
    private XRTableCell tableCell6;
    private XRTableCell tableCell7;
    private XRTableCell tableCell8;
    private XRTableCell tableCell9;
    private XRTableCell tableCell10;
    private XRTableCell tableCell11;
    private XRTableCell tableCell12;
    private XRTableCell tableCell13;
    private XRTableCell tableCell14;
    private XRTableCell tableCell15;
    private XRTableCell tableCell16;
    private XRTableCell tableCell17;
    private XRTableCell tableCell18;
    private XRTableCell tableCell19;
    private XRTableCell tableCell20;
    private XRTableCell tableCell21;
    private XRTableCell tableCell22;
    private XRTableCell tableCell23;
    private XRTableCell tableCell24;
    private XRTableCell tableCell25;
    private XRTableCell tableCell26;
    private XRTableCell tableCell27;
    private XRTableCell tableCell28;
    private XRTableCell tableCell29;
    private XRTableCell tableCell30;
    private XRTableCell tableCell31;
    private DetailBand Detail;
    private XRTable table2;
    private XRTableRow tableRow2;
    private XRTableCell tableCell32;
    private XRTableCell tableCell33;
    private XRTableCell tableCell34;
    private XRTableCell tableCell35;
    private XRTableCell tableCell36;
    private XRTableCell tableCell37;
    private XRTableCell tableCell38;
    private XRTableCell tableCell39;
    private XRTableCell tableCell40;
    private XRTableCell tableCell41;
    private XRTableCell tableCell42;
    private XRTableCell tableCell43;
    private XRTableCell tableCell44;
    private XRTableCell tableCell45;
    private XRTableCell tableCell46;
    private XRTableCell tableCell47;
    private XRTableCell tableCell48;
    private XRTableCell tableCell49;
    private XRTableCell tableCell50;
    private XRTableCell tableCell51;
    private XRTableCell tableCell52;
    private XRTableCell tableCell53;
    private XRTableCell tableCell54;
    private XRTableCell tableCell55;
    private XRTableCell tableCell56;
    private XRTableCell tableCell57;
    private XRTableCell tableCell58;
    private XRTableCell tableCell59;
    private XRTableCell tableCell60;
    private XRTableCell tableCell61;
    private XRTableCell tableCell62;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReportDescuentos()
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
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Json.CustomJsonSource customJsonSource1 = new DevExpress.DataAccess.Json.CustomJsonSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReportDescuentos));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode1 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode2 = new DevExpress.DataAccess.Json.JsonSchemaNode("login", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode3 = new DevExpress.DataAccess.Json.JsonSchemaNode("id", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode4 = new DevExpress.DataAccess.Json.JsonSchemaNode("node_id", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode5 = new DevExpress.DataAccess.Json.JsonSchemaNode("avatar_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode6 = new DevExpress.DataAccess.Json.JsonSchemaNode("gravatar_id", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode7 = new DevExpress.DataAccess.Json.JsonSchemaNode("url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode8 = new DevExpress.DataAccess.Json.JsonSchemaNode("html_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode9 = new DevExpress.DataAccess.Json.JsonSchemaNode("followers_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode10 = new DevExpress.DataAccess.Json.JsonSchemaNode("following_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode11 = new DevExpress.DataAccess.Json.JsonSchemaNode("gists_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode12 = new DevExpress.DataAccess.Json.JsonSchemaNode("starred_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode13 = new DevExpress.DataAccess.Json.JsonSchemaNode("subscriptions_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode14 = new DevExpress.DataAccess.Json.JsonSchemaNode("organizations_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode15 = new DevExpress.DataAccess.Json.JsonSchemaNode("repos_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode16 = new DevExpress.DataAccess.Json.JsonSchemaNode("events_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode17 = new DevExpress.DataAccess.Json.JsonSchemaNode("received_events_url", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode18 = new DevExpress.DataAccess.Json.JsonSchemaNode("type", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode19 = new DevExpress.DataAccess.Json.JsonSchemaNode("site_admin", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<bool>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode20 = new DevExpress.DataAccess.Json.JsonSchemaNode("name", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode21 = new DevExpress.DataAccess.Json.JsonSchemaNode("company", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode22 = new DevExpress.DataAccess.Json.JsonSchemaNode("blog", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode23 = new DevExpress.DataAccess.Json.JsonSchemaNode("location", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode24 = new DevExpress.DataAccess.Json.JsonSchemaNode("email", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode25 = new DevExpress.DataAccess.Json.JsonSchemaNode("hireable", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<bool>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode26 = new DevExpress.DataAccess.Json.JsonSchemaNode("bio", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode27 = new DevExpress.DataAccess.Json.JsonSchemaNode("public_repos", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode28 = new DevExpress.DataAccess.Json.JsonSchemaNode("public_gists", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode29 = new DevExpress.DataAccess.Json.JsonSchemaNode("followers", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode30 = new DevExpress.DataAccess.Json.JsonSchemaNode("following", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode31 = new DevExpress.DataAccess.Json.JsonSchemaNode("created_at", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<System.DateTime>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode32 = new DevExpress.DataAccess.Json.JsonSchemaNode("updated_at", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<System.DateTime>));
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // jsonDataSource1
            // 
            this.jsonDataSource1.ConnectionName = null;
            customJsonSource1.Json = resources.GetString("customJsonSource1.Json");
            this.jsonDataSource1.JsonSource = customJsonSource1;
            this.jsonDataSource1.Name = "jsonDataSource1";
            jsonSchemaNode1.Nodes.AddRange(new DevExpress.DataAccess.Node<DevExpress.DataAccess.Json.JsonNode>[] {
            jsonSchemaNode2,
            jsonSchemaNode3,
            jsonSchemaNode4,
            jsonSchemaNode5,
            jsonSchemaNode6,
            jsonSchemaNode7,
            jsonSchemaNode8,
            jsonSchemaNode9,
            jsonSchemaNode10,
            jsonSchemaNode11,
            jsonSchemaNode12,
            jsonSchemaNode13,
            jsonSchemaNode14,
            jsonSchemaNode15,
            jsonSchemaNode16,
            jsonSchemaNode17,
            jsonSchemaNode18,
            jsonSchemaNode19,
            jsonSchemaNode20,
            jsonSchemaNode21,
            jsonSchemaNode22,
            jsonSchemaNode23,
            jsonSchemaNode24,
            jsonSchemaNode25,
            jsonSchemaNode26,
            jsonSchemaNode27,
            jsonSchemaNode28,
            jsonSchemaNode29,
            jsonSchemaNode30,
            jsonSchemaNode31,
            jsonSchemaNode32});
            this.jsonDataSource1.Schema = jsonSchemaNode1;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 60F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 28F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(438F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(456F, 6F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(438F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Página {0} de {1}";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(888F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.Text = "ListadoDescuentos";
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(900F, 28F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8,
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14,
            this.tableCell15,
            this.tableCell16,
            this.tableCell17,
            this.tableCell18,
            this.tableCell19,
            this.tableCell20,
            this.tableCell21,
            this.tableCell22,
            this.tableCell23,
            this.tableCell24,
            this.tableCell25,
            this.tableCell26,
            this.tableCell27,
            this.tableCell28,
            this.tableCell29,
            this.tableCell30,
            this.tableCell31});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell1
            // 
            this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "DetailCaption1";
            this.tableCell1.StylePriority.UseBorders = false;
            this.tableCell1.Text = "login";
            this.tableCell1.Weight = 0.020988034142388239D;
            // 
            // tableCell2
            // 
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "DetailCaption1";
            this.tableCell2.Text = "id";
            this.tableCell2.Weight = 0.012287617789374457D;
            // 
            // tableCell3
            // 
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "DetailCaption1";
            this.tableCell3.Text = "node id";
            this.tableCell3.Weight = 0.027759119669596353D;
            // 
            // tableCell4
            // 
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StyleName = "DetailCaption1";
            this.tableCell4.Text = "avatar url";
            this.tableCell4.Weight = 0.033255312177870006D;
            // 
            // tableCell5
            // 
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "DetailCaption1";
            this.tableCell5.Text = "gravatar id";
            this.tableCell5.Weight = 0.036799507141113283D;
            // 
            // tableCell6
            // 
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "DetailCaption1";
            this.tableCell6.Text = "url";
            this.tableCell6.Weight = 0.014545589023166232D;
            // 
            // tableCell7
            // 
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "DetailCaption1";
            this.tableCell7.Text = "html url";
            this.tableCell7.Weight = 0.028405064476860895D;
            // 
            // tableCell8
            // 
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "DetailCaption1";
            this.tableCell8.Text = "followers url";
            this.tableCell8.Weight = 0.041627095540364582D;
            // 
            // tableCell9
            // 
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "DetailCaption1";
            this.tableCell9.Text = "following url";
            this.tableCell9.Weight = 0.041615761650933163D;
            // 
            // tableCell10
            // 
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StyleName = "DetailCaption1";
            this.tableCell10.Text = "gists url";
            this.tableCell10.Weight = 0.02969978544447157D;
            // 
            // tableCell11
            // 
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "DetailCaption1";
            this.tableCell11.Text = "starred url";
            this.tableCell11.Weight = 0.035830590989854604D;
            // 
            // tableCell12
            // 
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "DetailCaption1";
            this.tableCell12.Text = "subscriptions url";
            this.tableCell12.Weight = 0.0542003419664171D;
            // 
            // tableCell13
            // 
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StyleName = "DetailCaption1";
            this.tableCell13.Text = "organizations url";
            this.tableCell13.Weight = 0.053874541388617622D;
            // 
            // tableCell14
            // 
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StyleName = "DetailCaption1";
            this.tableCell14.Text = "repos url";
            this.tableCell14.Weight = 0.031957755618625218D;
            // 
            // tableCell15
            // 
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.StyleName = "DetailCaption1";
            this.tableCell15.Text = "events url";
            this.tableCell15.Weight = 0.034541539086235896D;
            // 
            // tableCell16
            // 
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.StyleName = "DetailCaption1";
            this.tableCell16.Text = "received events url";
            this.tableCell16.Weight = 0.059702207777235242D;
            // 
            // tableCell17
            // 
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.StyleName = "DetailCaption1";
            this.tableCell17.Text = "type";
            this.tableCell17.Weight = 0.019061533610026042D;
            // 
            // tableCell18
            // 
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.StyleName = "DetailCaption1";
            this.tableCell18.Text = "site admin";
            this.tableCell18.Weight = 0.035827759636773D;
            // 
            // tableCell19
            // 
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.StyleName = "DetailCaption1";
            this.tableCell19.Text = "name";
            this.tableCell19.Weight = 0.022288422054714627D;
            // 
            // tableCell20
            // 
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.StyleName = "DetailCaption1";
            this.tableCell20.Text = "company";
            this.tableCell20.Weight = 0.03260370042588976D;
            // 
            // tableCell21
            // 
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.StyleName = "DetailCaption1";
            this.tableCell21.Text = "blog";
            this.tableCell21.Weight = 0.019376006656222872D;
            // 
            // tableCell22
            // 
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.StyleName = "DetailCaption1";
            this.tableCell22.Text = "location";
            this.tableCell22.Weight = 0.029373982747395833D;
            // 
            // tableCell23
            // 
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.StyleName = "DetailCaption1";
            this.tableCell23.Text = "email";
            this.tableCell23.Weight = 0.021968284183078342D;
            // 
            // tableCell24
            // 
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.StyleName = "DetailCaption1";
            this.tableCell24.Text = "hireable";
            this.tableCell24.Weight = 0.029382481045193143D;
            // 
            // tableCell25
            // 
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.StyleName = "DetailCaption1";
            this.tableCell25.Text = "bio";
            this.tableCell25.Weight = 0.015831811692979602D;
            // 
            // tableCell26
            // 
            this.tableCell26.Name = "tableCell26";
            this.tableCell26.StyleName = "DetailCaption1";
            this.tableCell26.Text = "public repos";
            this.tableCell26.Weight = 0.041627095540364582D;
            // 
            // tableCell27
            // 
            this.tableCell27.Name = "tableCell27";
            this.tableCell27.StyleName = "DetailCaption1";
            this.tableCell27.Text = "public gists";
            this.tableCell27.Weight = 0.039369125366210934D;
            // 
            // tableCell28
            // 
            this.tableCell28.Name = "tableCell28";
            this.tableCell28.StyleName = "DetailCaption1";
            this.tableCell28.Text = "followers";
            this.tableCell28.Weight = 0.03260086907280816D;
            // 
            // tableCell29
            // 
            this.tableCell29.Name = "tableCell29";
            this.tableCell29.StyleName = "DetailCaption1";
            this.tableCell29.Text = "following";
            this.tableCell29.Weight = 0.032589537302652995D;
            // 
            // tableCell30
            // 
            this.tableCell30.Name = "tableCell30";
            this.tableCell30.StyleName = "DetailCaption1";
            this.tableCell30.Text = "created at";
            this.tableCell30.Weight = 0.03454437043931749D;
            // 
            // tableCell31
            // 
            this.tableCell31.Name = "tableCell31";
            this.tableCell31.StyleName = "DetailCaption1";
            this.tableCell31.Text = "updated at";
            this.tableCell31.Weight = 0.036465204026963974D;
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.OddStyleName = "DetailData3_Odd";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell32,
            this.tableCell33,
            this.tableCell34,
            this.tableCell35,
            this.tableCell36,
            this.tableCell37,
            this.tableCell38,
            this.tableCell39,
            this.tableCell40,
            this.tableCell41,
            this.tableCell42,
            this.tableCell43,
            this.tableCell44,
            this.tableCell45,
            this.tableCell46,
            this.tableCell47,
            this.tableCell48,
            this.tableCell49,
            this.tableCell50,
            this.tableCell51,
            this.tableCell52,
            this.tableCell53,
            this.tableCell54,
            this.tableCell55,
            this.tableCell56,
            this.tableCell57,
            this.tableCell58,
            this.tableCell59,
            this.tableCell60,
            this.tableCell61,
            this.tableCell62});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // tableCell32
            // 
            this.tableCell32.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[login]")});
            this.tableCell32.Name = "tableCell32";
            this.tableCell32.StyleName = "DetailData1";
            this.tableCell32.StylePriority.UseBorders = false;
            this.tableCell32.Weight = 0.020988034142388239D;
            // 
            // tableCell33
            // 
            this.tableCell33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[id]")});
            this.tableCell33.Name = "tableCell33";
            this.tableCell33.StyleName = "DetailData1";
            this.tableCell33.Weight = 0.012287616729736328D;
            // 
            // tableCell34
            // 
            this.tableCell34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[node_id]")});
            this.tableCell34.Name = "tableCell34";
            this.tableCell34.StyleName = "DetailData1";
            this.tableCell34.Weight = 0.027759117550320095D;
            // 
            // tableCell35
            // 
            this.tableCell35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[avatar_url]")});
            this.tableCell35.Name = "tableCell35";
            this.tableCell35.StyleName = "DetailData1";
            this.tableCell35.Weight = 0.033255310058593751D;
            // 
            // tableCell36
            // 
            this.tableCell36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[gravatar_id]")});
            this.tableCell36.Name = "tableCell36";
            this.tableCell36.StyleName = "DetailData1";
            this.tableCell36.Weight = 0.036799507141113283D;
            // 
            // tableCell37
            // 
            this.tableCell37.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[url]")});
            this.tableCell37.Name = "tableCell37";
            this.tableCell37.StyleName = "DetailData1";
            this.tableCell37.Weight = 0.014545587963528103D;
            // 
            // tableCell38
            // 
            this.tableCell38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[html_url]")});
            this.tableCell38.Name = "tableCell38";
            this.tableCell38.StyleName = "DetailData1";
            this.tableCell38.Weight = 0.028405062357584634D;
            // 
            // tableCell39
            // 
            this.tableCell39.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[followers_url]")});
            this.tableCell39.Name = "tableCell39";
            this.tableCell39.StyleName = "DetailData1";
            this.tableCell39.Weight = 0.041627095540364582D;
            // 
            // tableCell40
            // 
            this.tableCell40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[following_url]")});
            this.tableCell40.Name = "tableCell40";
            this.tableCell40.StyleName = "DetailData1";
            this.tableCell40.Weight = 0.041615761650933163D;
            // 
            // tableCell41
            // 
            this.tableCell41.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[gists_url]")});
            this.tableCell41.Name = "tableCell41";
            this.tableCell41.StyleName = "DetailData1";
            this.tableCell41.Weight = 0.029699783325195312D;
            // 
            // tableCell42
            // 
            this.tableCell42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[starred_url]")});
            this.tableCell42.Name = "tableCell42";
            this.tableCell42.StyleName = "DetailData1";
            this.tableCell42.Weight = 0.035830590989854604D;
            // 
            // tableCell43
            // 
            this.tableCell43.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[subscriptions_url]")});
            this.tableCell43.Name = "tableCell43";
            this.tableCell43.StyleName = "DetailData1";
            this.tableCell43.Weight = 0.054200337727864582D;
            // 
            // tableCell44
            // 
            this.tableCell44.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[organizations_url]")});
            this.tableCell44.Name = "tableCell44";
            this.tableCell44.StyleName = "DetailData1";
            this.tableCell44.Weight = 0.053874537150065106D;
            // 
            // tableCell45
            // 
            this.tableCell45.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[repos_url]")});
            this.tableCell45.Name = "tableCell45";
            this.tableCell45.StyleName = "DetailData1";
            this.tableCell45.Weight = 0.031957753499348956D;
            // 
            // tableCell46
            // 
            this.tableCell46.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[events_url]")});
            this.tableCell46.Name = "tableCell46";
            this.tableCell46.StyleName = "DetailData1";
            this.tableCell46.Weight = 0.034541536966959635D;
            // 
            // tableCell47
            // 
            this.tableCell47.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[received_events_url]")});
            this.tableCell47.Name = "tableCell47";
            this.tableCell47.StyleName = "DetailData1";
            this.tableCell47.Weight = 0.059702203538682726D;
            // 
            // tableCell48
            // 
            this.tableCell48.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[type]")});
            this.tableCell48.Name = "tableCell48";
            this.tableCell48.StyleName = "DetailData1";
            this.tableCell48.Weight = 0.019061533610026042D;
            // 
            // tableCell49
            // 
            this.tableCell49.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[site_admin]")});
            this.tableCell49.Name = "tableCell49";
            this.tableCell49.StyleName = "DetailData1";
            this.tableCell49.Weight = 0.035827759636773D;
            // 
            // tableCell50
            // 
            this.tableCell50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[name]")});
            this.tableCell50.Name = "tableCell50";
            this.tableCell50.StyleName = "DetailData1";
            this.tableCell50.Weight = 0.022288419935438369D;
            // 
            // tableCell51
            // 
            this.tableCell51.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[company]")});
            this.tableCell51.Name = "tableCell51";
            this.tableCell51.StyleName = "DetailData1";
            this.tableCell51.Weight = 0.0326036983066135D;
            // 
            // tableCell52
            // 
            this.tableCell52.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[blog]")});
            this.tableCell52.Name = "tableCell52";
            this.tableCell52.StyleName = "DetailData1";
            this.tableCell52.Weight = 0.019376006656222872D;
            // 
            // tableCell53
            // 
            this.tableCell53.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[location]")});
            this.tableCell53.Name = "tableCell53";
            this.tableCell53.StyleName = "DetailData1";
            this.tableCell53.Weight = 0.029373980628119575D;
            // 
            // tableCell54
            // 
            this.tableCell54.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[email]")});
            this.tableCell54.Name = "tableCell54";
            this.tableCell54.StyleName = "DetailData1";
            this.tableCell54.Weight = 0.021968284183078342D;
            // 
            // tableCell55
            // 
            this.tableCell55.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[hireable]")});
            this.tableCell55.Name = "tableCell55";
            this.tableCell55.StyleName = "DetailData1";
            this.tableCell55.Weight = 0.029382478925916885D;
            // 
            // tableCell56
            // 
            this.tableCell56.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[bio]")});
            this.tableCell56.Name = "tableCell56";
            this.tableCell56.StyleName = "DetailData1";
            this.tableCell56.Weight = 0.015831810633341471D;
            // 
            // tableCell57
            // 
            this.tableCell57.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[public_repos]")});
            this.tableCell57.Name = "tableCell57";
            this.tableCell57.StyleName = "DetailData1";
            this.tableCell57.Weight = 0.041627095540364582D;
            // 
            // tableCell58
            // 
            this.tableCell58.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[public_gists]")});
            this.tableCell58.Name = "tableCell58";
            this.tableCell58.StyleName = "DetailData1";
            this.tableCell58.Weight = 0.039369125366210934D;
            // 
            // tableCell59
            // 
            this.tableCell59.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[followers]")});
            this.tableCell59.Name = "tableCell59";
            this.tableCell59.StyleName = "DetailData1";
            this.tableCell59.Weight = 0.0326008669535319D;
            // 
            // tableCell60
            // 
            this.tableCell60.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[following]")});
            this.tableCell60.Name = "tableCell60";
            this.tableCell60.StyleName = "DetailData1";
            this.tableCell60.Weight = 0.032589535183376733D;
            // 
            // tableCell61
            // 
            this.tableCell61.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[created_at]")});
            this.tableCell61.Name = "tableCell61";
            this.tableCell61.StyleName = "DetailData1";
            this.tableCell61.Weight = 0.034544368320041235D;
            // 
            // tableCell62
            // 
            this.tableCell62.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[updated_at]")});
            this.tableCell62.Name = "tableCell62";
            this.tableCell62.StyleName = "DetailData1";
            this.tableCell62.Weight = 0.036465318467881945D;
            // 
            // XtraReportDescuentos
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.jsonDataSource1});
            this.DataSource = this.jsonDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
