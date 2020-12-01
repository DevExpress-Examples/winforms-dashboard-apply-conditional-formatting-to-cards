*Files to look at*:

* [Form1.cs](./CS/CardFormatRulesSample/Form1.cs) (VB: [Form1.vb](./VB/CardFormatRulesSample/Form1.vb))

# WinForms Dashboard - How to Apply Conditional Formatting to the Card Dashboard Item

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
