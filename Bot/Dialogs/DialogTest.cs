using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Bot.Dialogs
{
    [LuisModel("6dff0659-ba69-4964-8d8c-c31a9967f959", "88c80043fc3e46bb951e7a95d1210738")]
    [Serializable]
    public class DialogTest : LuisDialog<object>
    {
        [LuisIntent("Card")]
        public async Task Card(IDialogContext context, LuisResult result)
        {
            var reply = context.MakeMessage();
            reply.Attachments = new List<Attachment>();
            List<CardImage> images = new List<CardImage>();
            CardImage ci = new CardImage("https://tw.images.search.yahoo.com/search/images;_ylt=A8tUwZe5U6lZqRcAlQlr1gt.;_ylu=X3oDMTE0NW5ydGk3BGNvbG8DdHcxBHBvcwMxBHZ0aWQDQjQwNDFfMQRzZWMDcGl2cw--?p=AZURE&fr2=piv-web&fr=yset_ie_syc_oracle#id=4&iurl=http%3A%2F%2Faiscaler.com%2Fwp-content%2Fuploads%2F2014%2F07%2Fmicrosoft-azure-logo.jpg&action=click");
            images.Add(ci);
            CardAction ca = new CardAction()
            {
                Title = "Visit Support",
                Type = "openUrl",
                Value = "http://www.intelligentlabs.co.uk"
            };
            ThumbnailCard tc = new ThumbnailCard()
            {
                Title = "Need help?",
                Subtitle = "Go to our main site support.",
                Images = images,
                Tap = ca
            };
            reply.Attachments.Add(tc.ToAttachment());
            await context.PostAsync(reply);
            context.Wait(MessageReceived);

        }
    }
}