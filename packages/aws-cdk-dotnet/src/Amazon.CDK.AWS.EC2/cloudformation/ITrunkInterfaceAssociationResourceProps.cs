using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EC2.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html </remarks>
    [JsiiInterface(typeof(ITrunkInterfaceAssociationResourceProps), "@aws-cdk/aws-ec2.cloudformation.TrunkInterfaceAssociationResourceProps")]
    public interface ITrunkInterfaceAssociationResourceProps
    {
        /// <summary>``AWS::EC2::TrunkInterfaceAssociation.BranchInterfaceId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-branchinterfaceid </remarks>
        [JsiiProperty("branchInterfaceId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object BranchInterfaceId
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::TrunkInterfaceAssociation.TrunkInterfaceId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-trunkinterfaceid </remarks>
        [JsiiProperty("trunkInterfaceId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object TrunkInterfaceId
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::TrunkInterfaceAssociation.GREKey``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-grekey </remarks>
        [JsiiProperty("greKey", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object GreKey
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::TrunkInterfaceAssociation.VLANId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-vlanid </remarks>
        [JsiiProperty("vlanId", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object VlanId
        {
            get;
            set;
        }
    }
}