<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/254653126/20.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/t879233)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# BI Dashboard for WinForms - How to Apply Conditional Formatting to the Card Dashboard Item

![](/images/win-dashboard-conditional-formatting-card-example.png)

The example contains the following methods that apply a set of format rules to cards:

* **AddCommonRule**

  This method uses the series dimension values to calculate each rule. The rules apply to all the cards in the Card dashboard item.

* **AddRulesToTheFirstCard**/**AddRulesToTheSecondCard**

  These methods use card values to calculate each rule. The rules apply to the related card.

The table below lists format rules used in this example and the condition type they apply.

|Format Condition Type |  Rule Name | Appearance style |
|---|---|---|
|[Value](https://docs.devexpress.com/Dashboard/114402/common-features/appearance-customization/conditional-formatting/value?v=20.1)|   **backColorStyleRule** | Applies a light-green background color to cards whose actual value is equal to the set condition.
|                          |  **iconRule** | Applies full gray star icons to cards whose percentage variation value is greater than the set condition value.
|                          |  **fontStyleRule** | Applies the bold dark-blue font style to the cards' actual value that is between the range of condition values.
|                          |  **fontStyleUnderlinedRule**            | Applies the underlined red font style to the title of cards whose absolute variation value is less than the condition value.
|[Gradient Ranges](https://docs.devexpress.com/Dashboard/114407/common-features/appearance-customization/conditional-formatting/gradient-ranges?v=20.1) |  **rangeRule** | Applies a predefined range of colors to  cards.
|                          |  **gradientRule** | Applies a predefined range of colors to cards.
|[Icon Ranges](https://docs.devexpress.com/Dashboard/114405/common-features/appearance-customization/conditional-formatting/icon-ranges?v=20.1) | **deltaIconRule** | Applies the positive-negative icon range to cards.

## Files to Review

* [Form1.cs](./CS/CardFormatRulesSample/Form1.cs) (VB: [Form1.vb](./VB/CardFormatRulesSample/Form1.vb))

## Documentation

* [Conditional Formatting](https://docs.devexpress.com/Dashboard/401935) 

## More Examples
* [WinForms Dashboard - How to Highlight Data in a Scatter Chart Dashboard Item](https://github.com/DevExpress-Examples/WinForms-Dashboard-How-to-Highlight-Data-in-the-Scatter-Chart-Dashboard-Item)
* [How to Apply Conditional Formatting to the Chart Dashboard Item](https://github.com/DevExpress-Examples/WinForms-Dashboard-How-to-Apply-Conditional-Formatting-to-the-Chart-Dashboard-Item)
