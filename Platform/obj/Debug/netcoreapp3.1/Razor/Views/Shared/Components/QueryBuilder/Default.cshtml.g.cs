#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/QueryBuilder/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13c8e3e60e2fbaa82e94147c69cde30e4d5336e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_QueryBuilder_Default), @"mvc.1.0.view", @"/Views/Shared/Components/QueryBuilder/Default.cshtml")]
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13c8e3e60e2fbaa82e94147c69cde30e4d5336e3", @"/Views/Shared/Components/QueryBuilder/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_QueryBuilder_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"
<style>
    .e-query-builder .e-control-wrapper.e-slider-container.e-horizontal {
        height: 0;
    }

    #ruleContent {
        border: 1px solid #d3d3d3;
        width: 100%;
        height: 500px;
        overflow: auto;
    }
	
	.highcontrast textarea#ruleContent {
	  background-color: #000;
	}
    

</style>


<div class=""control-section"">
    <div id=""querybuilder"" class=""row"">
    </div>
</div>

<script>


 
    var elem;
    var dropDownObj;
    var boxObj;
    var ticksSlider;
    var filter = [{
        field: 'Category',
        label: 'Category',
        type: 'string'
    },
    {
        field: 'PaymentMode',
        label: 'PaymentMode',
        type: 'string',
        operators: [
            { key: 'Equal', value: 'equal' },
            { key: 'Not Equal', value: 'notequal' }
        ],
        template: {
            create: function () {
                elem = document.createElement('input');
                elem.setAttribute('type', 'text');
                return elem;
            ");
            WriteLiteral(@"},
            destroy: function (args) {
                var dropdown = ej.base.getComponent(document.getElementById(args.elementId), 'dropdownlist');
                if (dropdown) {
                    dropdown.destroy();
                }
            },
            write: function (args) {
                var ds = ['Cash', 'Debit Card', 'Credit Card', 'Net Banking', 'Wallet'];
                    dropDownObj = new ej.dropdowns.DropDownList({
                        dataSource: ds,
                        value: args.values ? args.values : ds[0],
                        change: function (e) {
                        qryBldrObj.notifyChange(e.itemData.value, e.element);
                        }
                    });
                    dropDownObj.appendTo('#' + args.elements.id);
            }
        }
    },
    {
        field: 'TransactionType',
        label: 'TransactionType',
        type: 'string',
        operators: [{
            key: 'Equal',
            value: 'equal'
        }, {
           ");
            WriteLiteral(@" key: 'Not Equal',
            value: 'notequal'
        }],
        template: {
            create: function () {
                elem = document.createElement('input');
                elem.setAttribute('type', 'checkbox');
                return elem;
            },
            destroy: function (args) {
                ej.base.getComponent(document.getElementById(args.elementId), 'checkbox').destroy();
            },
            write: function (args) {
                var checked = args.values === 'IsExpensive' ? true : false;
                boxObj = new ej.buttons.CheckBox({
                    label: 'Is Expensive',
                    checked: checked,
                    change: function (e) {
                        qryBldrObj.notifyChange(e.checked ? 'expensive' : 'income', e.event.target);
                    }
                });
                boxObj.appendTo('#' + args.elements.id);
            }
        }
    },
    {
        field: 'Description',
        label: 'Description',
        type: ");
            WriteLiteral(@"'string'
    },
    {
        field: 'Date',
        label: 'Date',
        type: 'date'
    },
    {
        field: 'Amount',
        label: 'Amount',
        type: 'number',
        operators: [
            { key: 'Equal', value: 'equal' },
            { key: 'Greater than', value: 'greaterthan' },
            { key: 'Less than', value: 'lessthan' },
            { key: 'Less than or equal', value: 'lessthanorequal' },
            { key: 'Greater than or equal', value: 'greaterthanorequal' },
            { key: 'Not equal', value: 'notequal' }
        ],
        template: {
            create: function () {
                elem = document.createElement('div');
                elem.setAttribute('class', 'ticks_slider');
                return elem;
            },
            destroy: function (args) {
                ej.base.getComponent(document.getElementById(args.elementId), 'slider').destroy();
            },
            write: function (args) {
                ticksSlider = new ej.inputs.Slider({
       ");
            WriteLiteral(@"             value: args.values,
                    min: 0,
                    max: 100,
                    tooltip: { isVisible: true, placement: 'Before', showOn: 'Hover' },
                    type: 'MinRange',
                    change: function (e) {
                        qryBldrObj.notifyChange(e.value, args.elements);
                    }
                });
                ticksSlider.appendTo('#' + args.elements.id);
            }
        }
    }
    ];
    var importRules = {
        'condition': 'and',
        'rules': [{
            'label': 'Category',
            'field': 'Category',
            'type': 'string',
            'operator': 'in',
            'value': ['Clothing']
        },
        {
            'condition': 'or',
            'rules': [{
                'label': 'TransactionType',
                'field': 'TransactionType',
                'type': 'string',
                'operator': 'equal',
                'value': 'Income'
            },
            {
                'lab");
            WriteLiteral(@"el': 'PaymentMode',
                'field': 'PaymentMode',
                'type': 'string',
                'operator': 'equal',
                'value': 'Cash'
            }
            ]
        }, {
            'label': 'Amount',
            'field': 'Amount',
            'type': 'number',
            'operator': 'equal',
            'value': 10
        }
        ]
    };
    var qryBldrObj = new ej.querybuilder.QueryBuilder({
        dataSource: window.expenseData,
        columns: filter,
        width: '100%',
        rule: importRules,
        ruleChange: updateRule
    });
    qryBldrObj.appendTo('#querybuilder');
   
    var element = document.getElementById('ruleContent');

    function updateRule(args) {
        if (ej.base.getComponent(radioButton.element, 'radio').checked) {
            element.textContent = qryBldrObj.getSqlFromRules(args.rule);
        } else {
            element.textContent = JSON.stringify(args.rule, null, 4);
        }
    }
    element.textContent = JSON.stringify(qryBld");
            WriteLiteral(@"rObj.getValidRules(qryBldrObj.rule), null, 4);

    function changeValue() {
        element = document.getElementById('ruleContent');
        var validRule = qryBldrObj.getValidRules(qryBldrObj.rule);
        if (ej.base.getComponent(radioButton.element, 'radio').checked) {
            element.textContent = qryBldrObj.getSqlFromRules(validRule);
        } else {
            element.textContent = JSON.stringify(validRule, null, 4);
        }
    }
    if (document.getElementById('right-pane')) {
        document.getElementById('right-pane').addEventListener('scroll', onScroll);
    }

    // Handler used to reposition the tooltip on page scroll
    function onScroll() {
        var tooltip = document.getElementsByClassName('e-handle e-control e-tooltip'), tooltipObj;
        for (var i = 0, len = tooltip.length; i < len; i++) {
			tooltipObj = tooltip[i].ej2_instances[0];
            // Refreshing each slider tooltip object position
			tooltipObj.refresh(tooltipObj.element);
		}
    }


</script>
");
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