using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bot.Dialogs
{

    public class Rootobject
    {
        public Recipient recipient { get; set; }
        public Message message { get; set; }
    }

    public class Recipient
    {
        public string id { get; set; }
    }

    public class Message
    {
        public Attachment1 attachment { get; set; }
    }

    public class Attachment1
    {
        public string type { get; set; }
        public Payload payload { get; set; }
    }

    public class Payload
    {
        public string template_type { get; set; }
        public string top_element_style { get; set; }
        public Element[] elements { get; set; }
        public Button1[] buttons { get; set; }
    }

    public class Element
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public string image_url { get; set; }
        public Button[] buttons { get; set; }
        public Default_Action default_action { get; set; }
    }

    public class Default_Action
    {
        public string type { get; set; }
        public string url { get; set; }
        public bool messenger_extensions { get; set; }
        public string webview_height_ratio { get; set; }
        public string fallback_url { get; set; }
    }

    public class Button
    {
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public bool messenger_extensions { get; set; }
        public string webview_height_ratio { get; set; }
        public string fallback_url { get; set; }
    }

    public class Button1
    {
        public string title { get; set; }
        public string type { get; set; }
        public string payload { get; set; }
    }

}