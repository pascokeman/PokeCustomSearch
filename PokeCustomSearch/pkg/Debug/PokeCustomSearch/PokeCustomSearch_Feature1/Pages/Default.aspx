<%-- The following 4 lines are ASP.NET directives needed when using SharePoint components --%>

<%@ Page Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" MasterPageFile="~masterurl/default.master" Language="C#" %>

<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%-- The markup and script in the following Content element will be placed in the <head> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
    <script src="https://appsforoffice.microsoft.com/lib/1/hosted/office.js" type="text/javascript"></script>
    <script type="text/javascript" src="../Scripts/jquery-3.5.1.min.js"></script>
    <SharePoint:ScriptLink name="sp.js" runat="server" OnDemand="true" LoadAfterUI="true" Localizable="false" />
    <meta name="WebPartPageExpansion" content="full" />
   
    <!-- Add your CSS styles to the following file -->
    <link rel="Stylesheet" type="text/css" href="../Content/App.css" />
    
    <!-- Add your JavaScript to the following file -->
    <script type="text/javascript" src="../Scripts/App.js"></script>
    
</asp:Content>

<%-- The markup in the following Content element will be placed in the TitleArea of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
    Poke Custom Search
</asp:Content>

<%-- The markup in the following Content element will be placed in the SearchArea of the page --%>
<asp:Content ContentPlaceHolderId="PlaceHolderSearchArea" runat="server"> 
</asp:Content>

<%-- The markup in the following Content element will be placed in the Left side of the page --%>
<asp:Content ContentPlaceHolderId="PlaceHolderLeftNavBar" runat="server"> 
    <div class="ms-searchCenter-refinement">
	    <label id="LabelDictionary"><u>S</u>earch Dictionary</label><br />
        <select name="searchList" id="searchList" onchange="searchDropDown($get('searchList').value); return false;">
            <option value="whiteFish">WhiteFish</option>
            <option value="jackFish">JackFish</option>
            <option value="permafrost">Permafrost</option>
            <option value="research">Research</option>
        </select>
        <br /><br />

        <label id="LabelAddDictionary"><u>A</u>dd new Search Word</label><br />
        <input type="text" value="New Search word" id="searchWord" />
        <button id="createSearchWordButton" onclick="createSearchWord($get('searchWord').value);return false;">Create SearchWord</button>
        
	</div>

</asp:Content>

<%-- The markup and script in the following Content element will be placed in the <body> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderMain" runat="server">
       
    <div style="float:left">              

        <div id="toolbarDiv" >
            <input type="text" style="width:500px; height:30px" id="queryTerms" />
            <button onclick="executeQuery($get('queryTerms').value);return false;">Search</button>
        </div>
        <div id="resultsDiv"></div>

    </div>       
</asp:Content>
