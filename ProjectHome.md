Googajax is a .NET library that encapsulates the Google REST Search API. It includes search interfaces for web, image, video, news, local, blog, book and patent searches. Includes web proxy support and the ability to download images.

**Example:**
```

GWebSearcher searcher = new GWebSearcher();

searcher.Query = SearchText;
searcher.ResultsSize = GResultsSize.Large;

try
{
	GWebResultSet results = searcher.Search();
	
	foreach (GWebResult result in results)
	{
	    Console.WriteLine("Title: " + result.Title);
	    Console.WriteLine("Title (No Formatting): " + result.TitleNoFormatting);
	    Console.WriteLine("Content: " + result.Content);
	    Console.WriteLine("Url: " + result.Url);
	    Console.WriteLine("Unescaped Url: " + result.UnescapedUrl);
	    Console.WriteLine("Visible Url: " + result.VisibleUrl);
	    Console.WriteLine("Cache Url: " + result.CacheUrl);
	    Console.WriteLine();
	}
	
	Console.WriteLine(new string('-', 25));
	Console.WriteLine("Current Page Index: " + results.Cursor.CurrentPageIndex);
	Console.WriteLine("Estimated Result Count: " + results.Cursor.EstimatedResultsCount);
	Console.WriteLine("More Results Url: " + results.Cursor.MoreResultsUrl);

}
catch (GSearchException gse)
{
	System.Console.WriteLine(gse.Message);
	System.Console.WriteLine(gse.StackTrace);
}
```