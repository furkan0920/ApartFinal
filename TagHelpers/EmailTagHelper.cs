using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ApartDeneme.TagHelpers
{//TODO CustomTagHelper
	public class EmailTagHelper:TagHelper
	{
		public string mail { get; set; }
		public string Display { get; set; }
		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName= "a";
			output.Attributes.Add("href", $"mailto:{mail}");
			output.Content.Append(Display);

		}
	}
}
