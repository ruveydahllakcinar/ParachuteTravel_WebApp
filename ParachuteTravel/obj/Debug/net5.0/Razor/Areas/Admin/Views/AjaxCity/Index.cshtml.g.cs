#pragma checksum "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\AjaxCity\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "156b1777ac7a73cb66f65a6bb7cbe3a35138e621"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AjaxCity_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AjaxCity/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156b1777ac7a73cb66f65a6bb7cbe3a35138e621", @"/Areas/Admin/Views/AjaxCity/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AjaxCity_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\AjaxCity\Index.cshtml"
      
        ViewData["Title"] = "Index";
        Layout = "~/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script src=""//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>

    <h2>Destination Ajax Transactions</h2>
    <br />

    <button type=""button"" id=""btngetlist"" class=""btn btn-outline-info"">City List</button>
    <button type=""button"" id=""btngetbyid"" class=""btn btn-outline-primary"">Call City</button>
    <button type=""button"" id=""btnaddcity"" class=""btn btn-outline-warning"">Add City</button>
    <button type=""button"" id=""btndeletecity"" class=""btn btn-outline-danger"">Delete City</button>
    <button type=""button"" id=""btnupdatecity"" class=""btn btn-outline-success"">Update City</button>

    <br />

    <br />
    <div>
        <input type=""text"" id=""txtid"" placeholder=""Please enter city Id"" class=""form-control"" />
    </div>
    <br />
    <div>
        <input type=""text"" id=""txtcityid"" placeholder=""Enter the ID value to be deleted"" class=""form-control"" />
    </div>
    <br />

    <div>
        <input type=""text"" id=""txtcityeditid"" placeholder=""enter the ID value ");
            WriteLiteral(@"to be updated"" class=""form-control"" />
        <br />
        <input type=""text"" id=""txtcityname"" placeholder=""enter the city value to be updated"" class=""form-control"" />
        <br />
        <input type=""text"" id=""txtcitdaynightname"" placeholder=""Enter the day and night information to be updated"" class=""form-control"" />
        <br />
    </div>
    <br />
    <div id=""destinationlistbyid"">

    </div>

    <br />
    <div>
        <input type=""text"" id=""txtcity"" placeholder=""Enter city name"" class=""form-control"" />
        <br />
        <input type=""text"" id=""txtdaynight"" placeholder=""Number of days - nights"" class=""form-control"" />
        <br />
        <input type=""text"" id=""txtprice"" placeholder=""Price"" class=""form-control"" />
        <br />
        <input type=""text"" id=""txtcapacity"" placeholder=""Number of people to stay"" class=""form-control"" />
    </div>

    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""applicati");
            WriteLiteral(@"on/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/AjaxCity/CityList/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<table class=table table-bordered> <tr><th> City Name </th> <th> Day-Nights </th> <th> Price </th> </tr>"";
                    $.each(w, (index, value) => {
                        tablehtml += `<tr><td>${value.CityName}</td> <td>${value.DayNight}</td> <td>${value.Capacity}</td><td> ${value.Price} $ </td> </tr>`
                    });
                    tablehtml += ""</table>"";
                    $(""#citylist"").html(tablehtml);
                }
            });
        });

        $(""#btnaddcity"").click(function () {
            let cityvalues = {
                CityName: $(""#txtcity"").val(),
                DayNight: $(""#txtdaynight"").val(),
                Price: $(""#txtprice"").val(),
          ");
            WriteLiteral(@"      Capacity: $(""#txtcapacity"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/AjaxCity/AddCityDestination/"",
                data: cityvalues,
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""City - Route Added Successfully"");
                }
            });
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#txtid"").val();

            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/AjaxCity/GetById/"",
                data: { DestinationId: id },
                success: function (fun2) {
                    let result = jQuery.parseJSON(fun2);
                    console.log(result);
                    let htmlstr = `<table class=table table-bordered><tr><th>City Name</th><th>Day-Nights</th><th>Price</th><th>Capacity</th>");
            WriteLiteral(@"</tr><tr><td>${result.CityName}</td><td>${result.DayNight}</td><td>${result.Price}$</td><td>${result.Capacity}</td></tr></table>`;
                    $(""#destinationlistbyid"").html(htmlstr);
                }
            });
        });

        $(""#btndeletecity"").click(x => {
            let id = $(""#txtcityid"").val();
            $.ajax({
                url: ""/Admin/AjaxCity/DeleteCity/"" + id,
                type: ""post"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function (fun3) {
                    alert(""city has been deleted."");
                }
            });
        });

        $(""#btnupdatecity"").click(function () {
            let values = {
                DestinationID: $(""#txtcityeditid"").val(),
                CityName: $(""#txtcityname"").val(),
                DayNight: $(""#txtcitdaynightname"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/A");
            WriteLiteral("jaxCity/UpdateCity/\",\r\n                data: values,\r\n                success: function (fun4) {\r\n                    alert(\"The update has been done\");\r\n                }\r\n            });\r\n        });\r\n\r\n    </script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591