using DevExpress.DashboardCommon;
using System.Drawing;
using System.Windows.Forms;

namespace CardFormatRulesSample {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.Dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");
            this.WindowState = FormWindowState.Maximized;
            CardDashboardItem cardItem = (CardDashboardItem)dashboardDesigner1.Dashboard.Items["cardDashboardItem1"];
            CardCompactLayoutTemplate layout = new CardCompactLayoutTemplate();
            CardCompactLayoutTemplate layout2 = new CardCompactLayoutTemplate();
            cardItem.Cards[0].LayoutTemplate = layout;
            cardItem.Cards[1].LayoutTemplate = layout2;

            AddRulesToTheFirstCard(cardItem.FormatRules, cardItem.Cards[0]);
            AddRulesToTheSecondCard(cardItem.FormatRules, cardItem.Cards[1]);
            AddCommonRule(cardItem.FormatRules, cardItem.SeriesDimensions[0]);
        }
        public void AddCommonRule(CardItemFormatRuleCollection formatRules, DataItem dataItem) {
            // Applies a light-green background color to cards whose actual value is equal to the set condition.
            CardItemFormatRule backColorStyleRule = new CardItemFormatRule(dataItem);
            backColorStyleRule.ApplyToLayoutElement = CardFormatRuleLayoutElement.ActualValue;
            FormatConditionValue valueCondition = new FormatConditionValue(DashboardFormatCondition.Equal, "Chain");
            valueCondition.StyleSettings = new AppearanceSettings(Color.LightGreen);
            backColorStyleRule.Condition = valueCondition;
            formatRules.Add(backColorStyleRule);
        }
        public void AddRulesToTheFirstCard(CardItemFormatRuleCollection formatRules, Card card) {
            // Applies a predefined range of colors to cards.
            CardItemDeltaFormatRule gradientRule = new CardItemDeltaFormatRule();
            gradientRule.DeltaValueType = DeltaValueType.AbsoluteVariation;
            gradientRule.Card = card;
            var rangeCondition = new FormatConditionRangeGradient(FormatConditionRangeGradientPredefinedType.BlueWhiteGreen);
            gradientRule.Condition = rangeCondition;
            formatRules.Add(gradientRule);

            // Applies the bold dark-blue font style to the cards' actual value that is between the range of condition values.
            CardItemFormatRule fontStyleRule = new CardItemFormatRule();
            fontStyleRule.DataItem = card.ActualValue;
            fontStyleRule.ApplyToLayoutElement = CardFormatRuleLayoutElement.ActualValue;
            FormatConditionValue valueCondition = new FormatConditionValue(DashboardFormatCondition.Between, 100000, 700000);
            valueCondition.StyleSettings = new AppearanceSettings(Color.DarkBlue, FontStyle.Bold);
            fontStyleRule.Condition = valueCondition;
            formatRules.Add(fontStyleRule);

            // Applies full gray star icons to cards whose percentage variation value is greater than the set condition value.
            CardItemDeltaFormatRule iconRule = new CardItemDeltaFormatRule(card, DeltaValueType.PercentVariation, CardFormatRuleLayoutElement.Title);
            FormatConditionValue valueCondition2 = new FormatConditionValue(DashboardFormatCondition.Greater, 0.1);
            valueCondition2.StyleSettings = new IconSettings(FormatConditionIconType.RatingFullGrayStar);
            iconRule.Condition = valueCondition2;
            formatRules.Add(iconRule);
        }
        public void AddRulesToTheSecondCard(CardItemFormatRuleCollection formatRules, Card card) {
            // Applies a predefined range of colors to cards.
            CardItemDeltaFormatRule rangeRule = new CardItemDeltaFormatRule();
            rangeRule.DeltaValueType = DeltaValueType.AbsoluteVariation;
            rangeRule.Card = card;
            var rangeCondition = new FormatConditionRangeSet(FormatConditionRangeSetPredefinedType.ColorsPaleRedOrangeYellowGreenBlue);
            rangeRule.Condition = rangeCondition;
            formatRules.Add(rangeRule);

            // Applies the underlined red font style to the title of cards whose absolute variation value is less than the condition value.
            CardItemDeltaFormatRule fontStyleUnderlinedRule = new CardItemDeltaFormatRule(card, DeltaValueType.AbsoluteVariation, CardFormatRuleLayoutElement.Title);
            FormatConditionValue valueCondition = new FormatConditionValue(DashboardFormatCondition.Less, 0);
            valueCondition.StyleSettings = new AppearanceSettings(Color.Red, FontStyle.Underline);
            fontStyleUnderlinedRule.Condition = valueCondition;
            formatRules.Add(fontStyleUnderlinedRule);

            // Applies the positive-negative icon range to cards.
            CardItemDeltaFormatRule deltaIconRule = new CardItemDeltaFormatRule(card, DeltaValueType.AbsoluteVariation, CardFormatRuleLayoutElement.Indicator);
            var iconRangeCondition = new FormatConditionRangeSet(FormatConditionRangeSetPredefinedType.PositiveNegative3);
            deltaIconRule.Condition = iconRangeCondition;
            formatRules.Add(deltaIconRule);
        }
    }
}
