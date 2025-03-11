﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WhatsappBusiness.CloudApi.Webhook
{
    /// <summary>
    /// A reaction message you received from a customer
    /// </summary>
    public class ReactionMessageReceived
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("entry")]
        public List<ReactionMessageEntry> Entry { get; set; }
    }

    public class ReactionMessageEntry
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("changes")]
        public List<ReactionMessageChange> Changes { get; set; }
    }

    public class ReactionMessageChange
    {
        [JsonPropertyName("value")]
        public ReactionMessageValue Value { get; set; }

        [JsonPropertyName("field")]
        public string Field { get; set; }
    }

    public class ReactionMessageValue
    {
        [JsonPropertyName("messaging_product")]
        public string MessagingProduct { get; set; }

        [JsonPropertyName("metadata")]
        public ReactionMessageMetadata Metadata { get; set; }

        [JsonPropertyName("contacts")]
        public List<Contact> Contacts { get; set; }

        [JsonPropertyName("messages")]
        public List<ReactionMessage> Messages { get; set; }
    }

    

    public class ReactionMessage:GenericMessage
    {        

        [JsonPropertyName("reaction")]
        public ReactionMessageText Reaction { get; set; }
    }

    public class ReactionMessageText
    {
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }

        [JsonPropertyName("emoji")]
        public string Emoji { get; set; }
    }

    public class ReactionMessageMetadata
    {
        [JsonPropertyName("display_phone_number")]
        public string DisplayPhoneNumber { get; set; }

        [JsonPropertyName("phone_number_id")]
        public string PhoneNumberId { get; set; }
    }
}