*Files to look at*:

* [Form1.cs](./CS/Form1.cs)(VB: [Form1.vb](./CS/Form1.vb))

# WinForms Dashboard - How to Apply Conditional Formatting to the Card Dashboard Item

![](~/images/win-dashboard-conditional-formatting-card-example.png)

The example contains the following methods that apply a set of format rules to cards:

* **AddCommonRule**

  This method uses the series dimension values to calculate each rule. The rules apply to all the cards in the Card dashboard item.

* **AddRulesToTheFirstCard**/**AddRulesToTheSecondCard**

  These methods use card values to calculate each rule. The rules apply to the related card.

The table below lists format rules used in this example and the condition type they apply.

|Format Condition Type |  Rule Name |
|---|---|
|[Value](https://docs.devexpress.com/Dashboard/114402/common-features/appearance-customization/conditional-formatting/value?v=20.1)|   **backColorStyleRule** 
|                          |  **iconRule** 
|                          |  **fontStyleRule** 
|[Gradient Ranges](https://docs.devexpress.com/Dashboard/114407/common-features/appearance-customization/conditional-formatting/gradient-ranges?v=20.1) |  **rangeRule** 
|                          |  **gradientRule** 
|[Icon Ranges](https://docs.devexpress.com/Dashboard/114405/common-features/appearance-customization/conditional-formatting/icon-ranges?v=20.1) | **deltaIconRule** 
