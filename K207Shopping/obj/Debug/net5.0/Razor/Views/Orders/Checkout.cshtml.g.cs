#pragma checksum "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ee8ea8b23ccaf23e9ceeecf7d9ff65092d16ef9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Checkout), @"mvc.1.0.view", @"/Views/Orders/Checkout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\_ViewImports.cshtml"
using K207Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\_ViewImports.cshtml"
using K207Shopping.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\_ViewImports.cshtml"
using K207Shopping.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee8ea8b23ccaf23e9ceeecf7d9ff65092d16ef9", @"/Views/Orders/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"343d6488144f2cd9d579c14ac277ab98721aabb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutVM>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- breadcrumb-area start -->
<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""row breadcrumb_box  align-items-center"">
                    <div class=""col-lg-6 col-md-6 col-sm-12 text-center text-md-left"">
                        <h2 class=""breadcrumb-title"">Shop</h2>
                    </div>
                    <div class=""col-lg-6  col-md-6 col-sm-12"">
                        <!-- breadcrumb-list start -->
                        <ul class=""breadcrumb-list text-center text-md-right"">
                            <li class=""breadcrumb-item""><a href=""/home/index"">Home</a></li>
                            <li class=""breadcrumb-item active"">Checkout</li>
                        </ul>
                        <!-- breadcrumb-list end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- breadcrumb-area end -->
<!-- checkout area start ");
            WriteLiteral("-->\r\n");
#nullable restore
#line 27 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""checkout-area pt-100px pb-100px"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-7"">
                    <div class=""billing-info-wrap"">
                        <h3>Billing Details</h3>
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>First Name</label>
                                    <input readonly");
            BeginWriteAttribute("value", " value=\"", 1613, "\"", 1652, 1);
#nullable restore
#line 39 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
WriteAttributeValue("", 1621, Model.K207User.Result.UserName, 1621, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text""/>
                                </div>
                            </div>


                            <div class=""col-lg-12"">
                                <div class=""billing-info mb-4"">
                                    <label>Street Address</label>
                                    <input class=""billing-address"" placeholder=""House number and street name"" type=""text"" />
                                    <input placeholder=""Apartment, suite, unit etc."" type=""text"" />
                                </div>
                            </div>

                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>Phone</label>
                                    <input readonly");
            BeginWriteAttribute("value", " value=\"", 2474, "\"", 2482, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" />
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>Email Address</label>
                                    <input readonly");
            BeginWriteAttribute("value", " value=\"", 2819, "\"", 2855, 1);
#nullable restore
#line 61 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
WriteAttributeValue("", 2827, Model.K207User.Result.Email, 2827, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" />
                                </div>
                            </div>
                        </div>
                        <div class=""checkout-account mb-30px"">
                            <input class=""checkout-toggle2 w-auto h-auto"" type=""checkbox"" />
                            <label>Create an account?</label>
                        </div>
                        <div class=""checkout-account-toggle open-toggle2 mb-30"">
                            <input placeholder=""Email address"" type=""email"" />
                            <input placeholder=""Password"" type=""password"" />
                            <button class=""btn-hover checkout-btn"" type=""submit"">register</button>
                        </div>
                        <div class=""additional-info-wrap"">
                            <h4>Additional information</h4>
                            <div class=""additional-info"">
                                <label>Order notes</label>
                                <t");
            WriteLiteral(@"extarea placeholder=""Notes about your order, e.g. special notes for delivery. "" name=""message""></textarea>
                            </div>
                        </div>
                        <div class=""checkout-account mt-25"">
                            <input class=""checkout-toggle w-auto h-auto"" type=""checkbox"" />
                            <label>Ship to a different address?</label>
                        </div>
                        <div class=""different-address open-toggle mt-30px"">
                            <div class=""row"">
                                <div class=""col-lg-6 col-md-6"">
                                    <div class=""billing-info mb-4"">
                                        <label>First Name</label>
                                        <input type=""text"" />
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-md-6"">
                                    <div class=""bil");
            WriteLiteral(@"ling-info mb-4"">
                                        <label>Last Name</label>
                                        <input type=""text"" />
                                    </div>
                                </div>
                                <div class=""col-lg-12"">
                                    <div class=""billing-info mb-4"">
                                        <label>Company Name</label>
                                        <input type=""text"" />
                                    </div>
                                </div>
                                <div class=""col-lg-12"">
                                    <div class=""billing-select mb-4"">
                                        <label>Country</label>
                                        <select>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee8ea8b23ccaf23e9ceeecf7d9ff65092d16ef910262", async() => {
                WriteLiteral("Select a country");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee8ea8b23ccaf23e9ceeecf7d9ff65092d16ef911275", async() => {
                WriteLiteral("Azerbaijan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee8ea8b23ccaf23e9ceeecf7d9ff65092d16ef912282", async() => {
                WriteLiteral("Bahamas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee8ea8b23ccaf23e9ceeecf7d9ff65092d16ef913286", async() => {
                WriteLiteral("Bahrain");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee8ea8b23ccaf23e9ceeecf7d9ff65092d16ef914290", async() => {
                WriteLiteral("Bangladesh");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee8ea8b23ccaf23e9ceeecf7d9ff65092d16ef915297", async() => {
                WriteLiteral("Barbados");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-lg-12"">
                                    <div class=""billing-info mb-4"">
                                        <label>Street Address</label>
                                        <input class=""billing-address"" placeholder=""House number and street name"" type=""text"" />
                                        <input placeholder=""Apartment, suite, unit etc."" type=""text"" />
                                    </div>
                                </div>
                                <div class=""col-lg-12"">
                                    <div class=""billing-info mb-4"">
                                        <label>Town / City</label>
                                        <input type=""text"" />
                                    </div>
                                </div>
                              ");
            WriteLiteral(@"  <div class=""col-lg-6 col-md-6"">
                                    <div class=""billing-info mb-4"">
                                        <label>State / County</label>
                                        <input type=""text"" />
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-md-6"">
                                    <div class=""billing-info mb-4"">
                                        <label>Postcode / ZIP</label>
                                        <input type=""text"" />
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-md-6"">
                                    <div class=""billing-info mb-4"">
                                        <label>Phone</label>
                                        <input type=""text"" />
                                    </div>
                                </div>
       ");
            WriteLiteral(@"                         <div class=""col-lg-6 col-md-6"">
                                    <div class=""billing-info mb-4"">
                                        <label>Email Address</label>
                                        <input type=""text"" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-5 mt-md-30px mt-lm-30px "">
                    <div class=""your-order-area"">
                        <h3>Your order</h3>
                        <div class=""your-order-wrap gray-bg-4"">
                            <div class=""your-order-product-info"">
                                <div class=""your-order-top"">
                                    <ul>
                                        <li>Product</li>
                                        <li>Total</li>
                                    </ul>
        ");
            WriteLiteral("                        </div>\r\n                                <div class=\"your-order-middle\">\r\n                                    <ul>\r\n");
#nullable restore
#line 172 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
                                          
                                            decimal total = 0;
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
                                         foreach (var product in Model.products)
                                        {
                                            int quantiy = Model.productIds.Where(x => x == product.ID).Count();
                                            total += quantiy * product.Price;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><span class=\"order-middle-left\"> ");
#nullable restore
#line 179 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
                                                                            Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" X ");
#nullable restore
#line 179 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
                                                                                            Write(quantiy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"order-price\">$ ");
#nullable restore
#line 179 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
                                                                                                                                         Write(product.Price*quantiy);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></li>\r\n");
#nullable restore
#line 180 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                                <div class=""your-order-bottom"">
                                    <ul>
                                        <li class=""your-order-shipping"">Shipping</li>
                                        <li>Free shipping</li>
                                    </ul>
                                </div>
                                <div class=""your-order-total"">
                                    <ul>
                                        <li class=""order-total"">Total</li>
");
            WriteLiteral("                                        <li> $ ");
#nullable restore
#line 193 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"
                                          Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""payment-method"">
                                <div class=""payment-accordion element-mrg"">
                                    <div id=""faq"" class=""panel-group"">
                                        <div class=""panel panel-default single-my-account m-0"">
                                            <div class=""panel-heading my-account-title"">
                                                <h4 class=""panel-title"">
                                                    <a data-bs-toggle=""collapse"" href=""#my-account-1"" class=""collapsed"" aria-expanded=""true"">Direct bank transfer</a>
                                                </h4>
                                            </div>
                                            <div id=""my-account-1"" class=""panel-collapse collapse show"" data-bs-parent=""#faq"">

                          ");
            WriteLiteral(@"                      <div class=""panel-body"">
                                                    <p>Please send a check to Store Name, Store Street, Store Town, Store State / County, Store Postcode.</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""panel panel-default single-my-account m-0"">
                                            <div class=""panel-heading my-account-title"">
                                                <h4 class=""panel-title""><a data-bs-toggle=""collapse"" href=""#my-account-2"" aria-expanded=""false"" class=""collapsed"">Check payments</a></h4>
                                            </div>
                                            <div id=""my-account-2"" class=""panel-collapse collapse"" data-bs-parent=""#faq"">

                                                <div class=""panel-body"">
                                    ");
            WriteLiteral(@"                <p>Please send a check to Store Name, Store Street, Store Town, Store State / County, Store Postcode.</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""panel panel-default single-my-account m-0"">
                                            <div class=""panel-heading my-account-title"">
                                                <h4 class=""panel-title""><a data-bs-toggle=""collapse"" href=""#my-account-3"">Cash on delivery</a></h4>
                                            </div>
                                            <div id=""my-account-3"" class=""panel-collapse collapse"" data-bs-parent=""#faq"">

                                                <div class=""panel-body"">
                                                    <p>Please send a check to Store Name, Store Street, Store Town, Store State / County, Store Postcode.</p>");
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""Place-order mt-25"">
                            <a class=""btn-hover"" href=""#"">Place Order</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 247 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""empty-cart-area pb-100px pt-100px"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""cart-heading"">
                        <h2>Your cart item</h2>
                    </div>
                    <div class=""empty-text-contant text-center"">
                        <i class=""icon-handbag""></i>
                        <h1>There are no more items in your cart</h1>
                        <a class=""empty-cart-btn"" href=""/home/index"">
                            <i class=""ion-ios-arrow-left""> </i> Continue shopping
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 269 "C:\Users\USER\source\repos\K207Shopping\K207Shopping\Views\Orders\Checkout.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- checkout area end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
