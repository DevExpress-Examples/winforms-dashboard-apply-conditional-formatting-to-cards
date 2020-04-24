Imports DevExpress.DashboardCommon
Imports System.Drawing
Imports System.Windows.Forms

Namespace CardFormatRulesSample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.CreateRibbon()
			dashboardDesigner1.Dashboard.LoadFromXml("..\..\Data\Dashboard.xml")
			Me.WindowState = FormWindowState.Maximized
			Dim cardItem As CardDashboardItem = CType(dashboardDesigner1.Dashboard.Items("cardDashboardItem1"), CardDashboardItem)
			Dim layout As New CardCompactLayoutTemplate()
			Dim layout2 As New CardCompactLayoutTemplate()
			cardItem.Cards(0).LayoutTemplate = layout
			cardItem.Cards(1).LayoutTemplate = layout2

			AddRulesToTheFirstCard(cardItem.FormatRules, cardItem.Cards(0))
			AddRulesToTheSecondCard(cardItem.FormatRules, cardItem.Cards(1))
			AddCommonRule(cardItem.FormatRules, cardItem.SeriesDimensions(0))
		End Sub
		Public Sub AddCommonRule(ByVal formatRules As CardItemFormatRuleCollection, ByVal dataItem As DataItem)
			' Applies a light-green background color to cards whose actual value is equal to the set condition.
			Dim backColorStyleRule As New CardItemFormatRule(dataItem)
			backColorStyleRule.ApplyToLayoutElement = CardFormatRuleLayoutElement.ActualValue
			Dim valueCondition As New FormatConditionValue(DashboardFormatCondition.Equal, "Chain")
			valueCondition.StyleSettings = New AppearanceSettings(Color.LightGreen)
			backColorStyleRule.Condition = valueCondition
			formatRules.Add(backColorStyleRule)
		End Sub
		Public Sub AddRulesToTheFirstCard(ByVal formatRules As CardItemFormatRuleCollection, ByVal card As Card)
			' Applies a predefined range of colors to cards.
			Dim gradientRule As New CardItemDeltaFormatRule()
			gradientRule.DeltaValueType = DeltaValueType.AbsoluteVariation
			gradientRule.Card = card
			Dim rangeCondition = New FormatConditionRangeGradient(FormatConditionRangeGradientPredefinedType.BlueWhiteGreen)
			gradientRule.Condition = rangeCondition
			formatRules.Add(gradientRule)

			' Applies the bold dark-blue font style to the cards' actual value that is between the range of condition values.
			Dim fontStyleRule As New CardItemFormatRule()
			fontStyleRule.DataItem = card.ActualValue
			fontStyleRule.ApplyToLayoutElement = CardFormatRuleLayoutElement.ActualValue
			Dim valueCondition As New FormatConditionValue(DashboardFormatCondition.Between, 100000, 700000)
			valueCondition.StyleSettings = New AppearanceSettings(Color.DarkBlue, FontStyle.Bold)
			fontStyleRule.Condition = valueCondition
			formatRules.Add(fontStyleRule)

			' Applies full gray star icons to cards whose percentage variation value is greater than the set condition value.
			Dim iconRule As New CardItemDeltaFormatRule(card, DeltaValueType.PercentVariation, CardFormatRuleLayoutElement.Title)
			Dim valueCondition2 As New FormatConditionValue(DashboardFormatCondition.Greater, 0.1)
			valueCondition2.StyleSettings = New IconSettings(FormatConditionIconType.RatingFullGrayStar)
			iconRule.Condition = valueCondition2
			formatRules.Add(iconRule)
		End Sub
		Public Sub AddRulesToTheSecondCard(ByVal formatRules As CardItemFormatRuleCollection, ByVal card As Card)
			' Applies a predefined range of colors to cards.
			Dim rangeRule As New CardItemDeltaFormatRule()
			rangeRule.DeltaValueType = DeltaValueType.AbsoluteVariation
			rangeRule.Card = card
			Dim rangeCondition = New FormatConditionRangeSet(FormatConditionRangeSetPredefinedType.ColorsPaleRedOrangeYellowGreenBlue)
			rangeRule.Condition = rangeCondition
			formatRules.Add(rangeRule)

			' Applies the underlined red font style to the title of cards whose absolute variation value is less than the condition value.
			Dim fontStyleUnderlinedRule As New CardItemDeltaFormatRule(card, DeltaValueType.AbsoluteVariation, CardFormatRuleLayoutElement.Title)
			Dim valueCondition As New FormatConditionValue(DashboardFormatCondition.Less, 0)
			valueCondition.StyleSettings = New AppearanceSettings(Color.Red, FontStyle.Underline)
			fontStyleUnderlinedRule.Condition = valueCondition
			formatRules.Add(fontStyleUnderlinedRule)

			' Applies the positive-negative icon range to cards.
			Dim deltaIconRule As New CardItemDeltaFormatRule(card, DeltaValueType.AbsoluteVariation, CardFormatRuleLayoutElement.Indicator)
			Dim iconRangeCondition = New FormatConditionRangeSet(FormatConditionRangeSetPredefinedType.PositiveNegative3)
			deltaIconRule.Condition = iconRangeCondition
			formatRules.Add(deltaIconRule)
		End Sub
	End Class
End Namespace
