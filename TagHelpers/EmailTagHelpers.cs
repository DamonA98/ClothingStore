/*
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ClothingStore.TagHelpers
{
    public class EmailTagHelpers: TagHelper
    {
        public string? Adress { get; set; }
        public string? Content { get; set; }

        public override void Proccess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Adress);
            output.Content.SetContent(Content);
        }
    }
}*/
