'use strict';

var Results;
var siteURL;

// This code runs when the DOM is ready and creates a context object which is needed to use the SharePoint object model
$(document).ready(function () {
    siteURL = _spPageContextInfo.webAbsoluteUrl;
    showToolbar();
})

//updates the dictionary dropdown from the TKAIDictionary List
function bindDropDown() {
    $.ajax
        ({
            url: siteURL + "/_api/web/lists/getByTitle('TKAI%20Dictionary')",
            method: "GET",
            headers: {
                "Accept": "application/json;odata=verbose",
            },
            success: function (data, status, xhr) {
                var results = data.d.query.PrimaryQueryResult.RelevantResults.Table.Rows.results;
                
            },
            error: function (xhr, status, error) {
                alert(JSON.stringify(error) + ":" + xhr.responseText);
            }
        });
}

function searchDropDown(selectedItem) {
    createSearchWord(selectedItem);
}

function createSearchWord(searchWord) {
    var objTitle = {
        '__metadata': { 'type': 'SP.FieldText' },
        'FieldTypeKind': 2,
        'Title': searchWord
    };
        
    $.ajax
        ({   
            url: "https://auroracollegedev.sharepoint.com/sites/developmentsite/_api/web/lists/getByTitle('TKAI%20Dictionary')/fields",
            method: "POST",            
            data: JSON.stringify(objTitle),
            headers: {
                "Accept": "application/json;odata=verbose",
                "Content-Type": "application/json;odata=verbose",
                "X-RequestDigest": $("#__REQUESTDIGEST").val()
            },
            success: function (data, status, xhr) {
                alert("Added Successfully!");
            },
            error: function (xhr, status, error) {
                alert(JSON.stringify(error) + ":" + xhr.responseText);
            }
        });
}

function showToolbar() {
    $("toolbarDiv").show();
}

function executeQuery(queryTerms) {     
    Results = {
        element: '',
        url: '',
        init: function (element) {
            Results.element = element;
            Results.url = siteURL + "/_api/search/query?querytext='" + "%" + queryTerms + "%" + "'";
        },
        load: function () {
            $.ajax({
                url: Results.url,
                method: "GET",
                headers: { "ACCEPT": "application/json;odata=verbose" },
                success: Results.onSuccess,
                error: Results.onError
            });
        },
        onError: function (error) {
            alert(JSON.stringify(error));
        },
        onSuccess: function (data) {

            var results = data.d.query.PrimaryQueryResult.RelevantResults.Table.Rows.results;

            if (results.length == 0) {
                $('#resultsDiv').text('No related documents were found');                
            } else {
                $("#resultsDiv").append('<table>');

                $.each(results, function () {
                    $("#resultsDiv").append('<tr>');
                    $.each(this.Cells.results, function () {
                        switch (this.Key) {
                            case 'Title': $("#resultsDiv").append('<td>' + this.Value + '</td>'); break;
                            case 'Author': $("#resultsDiv").append('<td>' + this.Value + '</td>'); break;
                            case 'LastModifiedTime': $("#resultsDiv").append('<td>' + Date(this.Value) + '</td>'); break;
                            case 'HitHighlightedSummary': $("#resultsDiv").append('<td>' + this.Value + '</td>'); break;
                            case 'FileExtension': $("#resultsDiv").append('<td>' + this.Value + '</td>'); break;
                            case 'OriginalPath': $("#resultsDiv").append('<td>' + this.Value + '</td>'); break;
                        }
                        //check if file is a word document and pass the path into the searchWordDocument function
                        if (this.Key == "Path" && this.Value.includes("docx")) {                        
                            searchWordDocument(this.Value);
                        }
                    });
                    $("#resultsDiv").append('</tr>');
                });
                $("#resultsDiv").append('</table>');
            }
        }
    }
    Results.init($("resultsDiv"));
    Results.load();
}

function searchWordDocument(myUrl) {
    if (myUrl) {        
        Office.getContext = myUrl;

        //continue from here... open the word document using the url and search the content(context)
        $.ajax({
            url: myUrl,
            method: "GET",
            withCredentials: true,
            headers: {
                "ACCEPT": "application/json;odata=verbose",
                "Content-Type": "application/json;odata=verbose"
            },
            success: function (data, status, xhr) {
                var returnData = data;

            },
            error: function (xhr, status, error) {
                var sucResult = JSON.stringify(error) + ":" + xhr.responseText;

            }

        })
    }
    
    
}
