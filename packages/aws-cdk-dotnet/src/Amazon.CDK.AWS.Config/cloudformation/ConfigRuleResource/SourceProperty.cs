using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Config.cloudformation.ConfigRuleResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html </remarks>
    public class SourceProperty : DeputyBase, ISourceProperty
    {
        /// <summary>``ConfigRuleResource.SourceProperty.Owner``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-owner </remarks>
        [JsiiProperty("owner", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object Owner
        {
            get;
            set;
        }

        /// <summary>``ConfigRuleResource.SourceProperty.SourceDetails``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-sourcedetails </remarks>
        [JsiiProperty("sourceDetails", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-config.cloudformation.ConfigRuleResource.SourceDetailProperty\"}]}}}}]},\"optional\":true}", true)]
        public object SourceDetails
        {
            get;
            set;
        }

        /// <summary>``ConfigRuleResource.SourceProperty.SourceIdentifier``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html#cfn-config-configrule-source-sourceidentifier </remarks>
        [JsiiProperty("sourceIdentifier", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object SourceIdentifier
        {
            get;
            set;
        }
    }
}