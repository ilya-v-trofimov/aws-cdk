import json
import pytest

from aws_cdk import core
from %name%.%name%_stack import %name.PascalCased%Stack


def get_template():
    app = core.App()
    %name.PascalCased%Stack(app, "%name%")
    return json.dumps(app.synth().get_stack("%name%").template)


def test_sqs_queue_created():
    template_json = get_template()
    assert("AWS::SQS::Queue" in get_template())


def test_sns_topic_created():
    assert("AWS::SNS::Topic" in get_template())
