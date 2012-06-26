using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Googajax;

namespace Example
{
    class Program
    {
        public string SearchText
        {
            get;
            set;
        }

        public void runWebSearch()
        {
            GWebSearcher searcher = new GWebSearcher();

            searcher.Query = SearchText;
            searcher.ResultsSize = GResultsSize.Large;
            searcher.HostLanguage = GHostLanguage.English;

            try
            {
                Console.WriteLine("RUNNING WEB SEARCH");
                Console.WriteLine(new string('-', 25));

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
        }

        public void runImageSearch()
        {
            GImageSearcher search = new GImageSearcher();

            search.Query = SearchText;
            search.SafetyLevel = GSafetyLevel.Off;
            search.FileType = GImageFileType.Jpg;
            search.ImageColor = GImageColor.Blue;

            search.ImageRights |= GImageRights.IncludePublicDomain;
            search.ImageRights |= GImageRights.IncludeShareAlike;
            search.ImageRights |= GImageRights.IncludeAttribute;
            search.ImageRights |= GImageRights.ExcludeNonDerived;

            try
            {
                Console.WriteLine("RUNNING IMAGE SEARCH");
                Console.WriteLine(new string('-', 25));

                GImageResultSet results = search.Search();

                foreach (GImageResult result in results)
                {
                    Console.WriteLine("Title: " + result.Title);
                    Console.WriteLine("Title (No Formatting): " + result.TitleNoFormatting);
                    Console.WriteLine("Content: " + result.Content);
                    Console.WriteLine("Content (No Formatting): " + result.ContentNoFormatting);
                    Console.WriteLine("Image ID: " + result.ImageId);
                    Console.WriteLine("Image Height: " + result.ImageHeight);
                    Console.WriteLine("Image Width: " + result.ImageWidth);
                    Console.WriteLine("Url: " + result.Url);
                    Console.WriteLine("Unescaped Url: " + result.UnescapedUrl);
                    Console.WriteLine("Visible Url: " + result.VisibleUrl);
                    Console.WriteLine("Original Context Url: " + result.OriginalContextUrl);
                    Console.WriteLine("Thumbnail Url: " + result.ThumbnailUrl);
                    Console.WriteLine("Thumbnail Height: " + result.ThumbnailHeight);
                    Console.WriteLine("Thumbnail Width: " + result.ThumbnailWidth);
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
        }

        public void runNewsSearch()
        {
            GNewsSearcher search = new GNewsSearcher();

            search.Query = SearchText;
            search.ResultsSize = GResultsSize.Large;

            try
            {
                Console.WriteLine("RUNNING NEWS SEARCH");
                Console.WriteLine(new string('-', 25));

                GNewsResultSet results = search.Search();

                foreach (GNewsResult result in results)
                {
                    Console.WriteLine("Title: " + result.Title);
                    Console.WriteLine("Title (No Formatting): " + result.TitleNoFormatting);
                    Console.WriteLine("Content: " + result.Content);
                    Console.WriteLine("Publisher: " + result.Publisher);
                    Console.WriteLine("Published Date: " + result.PublishedDate);
                    Console.WriteLine("Location: " + result.Location);
                    Console.WriteLine("Language: " + result.Language);
                    Console.WriteLine("Url: " + result.Url);
                    Console.WriteLine("Unescaped Url: " + result.UnescapedUrl);
                    Console.WriteLine("Signed Redirect Url: " + result.SignedRedirectUrl);
                    Console.WriteLine("Cluster Url: " + result.ClusterUrl);

                    if (result.HasImage)
                    {
                        GImageResult image = result.Image;
                        Console.WriteLine("Image Url: " + image.Url);
                        Console.WriteLine("Image Original Context Url: " + image.OriginalContextUrl);
                        Console.WriteLine("Image Thumbnail Url: " + image.ThumbnailUrl);
                        Console.WriteLine("Image Thumbnail Height: " + image.ThumbnailHeight);
                        Console.WriteLine("Image Thumbnail Width: " + image.ThumbnailWidth);
                    }

                    foreach (GNewsResult story in result.RelatedStories)
                    {
                        Console.WriteLine(new string('-', 25));
                        Console.WriteLine("Story Title: " + story.Title);
                        Console.WriteLine("Story Title (No Formatting): " + story.TitleNoFormatting);
                        Console.WriteLine("Story Publisher: " + story.Publisher);
                        Console.WriteLine("Story Published Date: " + story.PublishedDate);
                        Console.WriteLine("Story Url: " + story.Url);
                        Console.WriteLine("Story Unescaped Url: " + story.UnescapedUrl);
                        Console.WriteLine("Story Signed Redirect Url: " + story.SignedRedirectUrl);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine(new string('-', 25));
                Console.WriteLine("Current Page Index: " + results.Cursor.CurrentPageIndex);
                Console.WriteLine("Estimated Result Count: " + results.Cursor.EstimatedResultsCount);
                Console.WriteLine("More Results Url: " + results.Cursor.MoreResultsUrl);
            }
            catch (Exception gse)
            {
                System.Console.WriteLine(gse.Message);
                System.Console.WriteLine(gse.StackTrace);
            }
        }


        public void runVideoSearch()
        {
            GVideoSearcher search = new GVideoSearcher();

            search.Query = SearchText;
            search.ResultsSize = GResultsSize.Large;

            try
            {
                GVideoResultSet results = search.Search();

                Console.WriteLine("RUNNING VIDEO SEARCH");
                Console.WriteLine(new string('-', 25));

                foreach (GVideoResult result in results)
                {
                    Console.WriteLine("Title: " + result.Title);
                    Console.WriteLine("Title (No Formatting): " + result.TitleNoFormatting);
                    Console.WriteLine("Content: " + result.Content);
                    Console.WriteLine("Duration: " + result.Duration);
                    Console.WriteLine("Rating: " + result.Rating);
                    Console.WriteLine("Publisher: " + result.Publisher);
                    Console.WriteLine("Published Date: " + result.PublishedDate);
                    Console.WriteLine("Video Type: " + result.VideoType);
                    Console.WriteLine("Play Url: " + result.PlayUrl);
                    Console.WriteLine("Url: " + result.Url);
                    Console.WriteLine("Image Thumbnail Url: " + result.ThumbnailUrl);
                    Console.WriteLine("Image Thumbnail Height: " + result.ThumbnailHeight);
                    Console.WriteLine("Image Thumbnail Width: " + result.ThumbnailWidth);
                    Console.WriteLine();
                }

                Console.WriteLine(new string('-', 25));
                Console.WriteLine("Current Page Index: " + results.Cursor.CurrentPageIndex);
                Console.WriteLine("Estimated Result Count: " + results.Cursor.EstimatedResultsCount);
                Console.WriteLine("More Results Url: " + results.Cursor.MoreResultsUrl);
            }
            catch (Exception gse)
            {
                System.Console.WriteLine(gse.Message);
                System.Console.WriteLine(gse.StackTrace);
            }
        }

        public void runBlogSearch()
        {
            GBlogSearcher search = new GBlogSearcher();

            search.Query = SearchText;
            search.ResultsSize = GResultsSize.Large;

            try
            {
                Console.WriteLine("RUNNING BLOG SEARCH");
                Console.WriteLine(new string('-', 25));

                GBlogResultSet results = search.Search();

                foreach (GBlogResult result in results)
                {
                    Console.WriteLine("Title: " + result.Title);
                    Console.WriteLine("Title (No Formatting): " + result.TitleNoFormatting);
                    Console.WriteLine("Content: " + result.Content);
                    Console.WriteLine("Author: " + result.Author);
                    Console.WriteLine("Published Date: " + result.PublishedDate);
                    Console.WriteLine("Blog Url: " + result.BlogUrl);
                    Console.WriteLine("Post Url: " + result.PostUrl);
                    Console.WriteLine();
                }

                Console.WriteLine(new string('-', 25));
                Console.WriteLine("Current Page Index: " + results.Cursor.CurrentPageIndex);
                Console.WriteLine("Estimated Result Count: " + results.Cursor.EstimatedResultsCount);
                Console.WriteLine("More Results Url: " + results.Cursor.MoreResultsUrl);
            }
            catch (Exception gse)
            {
                System.Console.WriteLine(gse.Message);
                System.Console.WriteLine(gse.StackTrace);
            }
        }

        public void runBookSearch()
        {
            GBookSearcher search = new GBookSearcher();

            search.Query = SearchText;
            search.ResultsSize = GResultsSize.Large;

            try
            {
                Console.WriteLine("RUNNING BOOK SEARCH");
                Console.WriteLine(new string('-', 25));

                GBookResultSet results = search.Search();

                foreach (GBookResult result in results)
                {
                    Console.WriteLine("Title: " + result.Title);
                    Console.WriteLine("Title (No Formatting): " + result.TitleNoFormatting);
                    Console.WriteLine("Book ID: " + result.BookId);
                    Console.WriteLine("Authors: " + result.Authors);
                    Console.WriteLine("Page Count: " + result.PageCount);
                    Console.WriteLine("Published Year: " + result.PublishedYear);
                    Console.WriteLine("Url: " + result.Url);
                    Console.WriteLine("Unescaped Url: " + result.UnescapedUrl);
                    Console.WriteLine("Thumbnail Url: " + result.ThumbnailUrl);
                    Console.WriteLine("Thumbnail Height: " + result.ThumbnailHeight);
                    Console.WriteLine("Thumbnail Width: " + result.ThumbnailWidth);
                    Console.WriteLine();
                }

                Console.WriteLine(new string('-', 25));
                Console.WriteLine("Current Page Index: " + results.Cursor.CurrentPageIndex);
                Console.WriteLine("Estimated Result Count: " + results.Cursor.EstimatedResultsCount);
                Console.WriteLine("More Results Url: " + results.Cursor.MoreResultsUrl);
            }
            catch (Exception gse)
            {
                System.Console.WriteLine(gse.Message);
                System.Console.WriteLine(gse.StackTrace);
            }
        }

        public void runLocalSearch()
        {
            GLocalSearcher search = new GLocalSearcher();

            search.Query = SearchText;
            search.ResultsSize = GResultsSize.Large;

            try
            {
                Console.WriteLine("RUNNING LOCAL SEARCH");
                Console.WriteLine(new string('-', 25));

                GLocalResultSet results = search.Search();

                GViewport viewport = results.Viewport;
                Console.WriteLine("Viewport Center Lat/Lng: " + viewport.Center.Latitude + ", " + viewport.Center.Longitude);
                Console.WriteLine("Viewport Span Lat/Lng: " + viewport.Span.Latitude + ", " + viewport.Span.Longitude);
                Console.WriteLine("Viewport NE Lat/Lng: " + viewport.Northeast.Latitude + ", " + viewport.Northeast.Longitude);
                Console.WriteLine("Viewport SW Lat/Lng: " + viewport.Southwest.Latitude + ", " + viewport.Southwest.Longitude);
                Console.WriteLine(new string('-', 25));
                Console.WriteLine();

                foreach (GLocalResult result in results)
                {
                    Console.WriteLine("Title: " + result.Title);
                    Console.WriteLine("Title (No Formatting): " + result.TitleNoFormatting);
                    Console.WriteLine("Content: " + result.Content);
                    Console.WriteLine("Listing Type: " + result.ListingType);
                    Console.WriteLine("Accuracy: " + result.Accuracy);
                    Console.WriteLine("Max Age: " + result.MaxAge);
                    Console.WriteLine("Viewport Mode: " + result.ViewportMode);
                    Console.WriteLine("Lat/Lng: " + result.Latitude + ", " + result.Longitude);
                    Console.WriteLine("Street Address: " + result.StreetAddress);
                    Console.WriteLine("City: " + result.City);
                    Console.WriteLine("Country: " + result.Country);
                    Console.WriteLine("Region: " + result.Region);
                    Console.WriteLine("Driving Directions Url: " + result.DrivingDirectionsUrl);
                    Console.WriteLine("Driving Directions Url (To Here): " + result.DrivingDirectionsToHereUrl);
                    Console.WriteLine("Driving Directions Url (From Here): " + result.DrivingDirectionsFromHereUrl);
                    Console.WriteLine("Static Map Url: " + result.StaticMapUrl);

                    Console.WriteLine("Address Lines:");
                    foreach (string addressLine in result.AddressLines)
                    {
                        Console.WriteLine("\t" + addressLine);
                    }

                    foreach (GPhoneNumber phoneNumber in result.PhoneNumbers)
                    {
                        Console.WriteLine("Phone Number: " + phoneNumber.Number);
                    }

                    Console.WriteLine();

                    Console.WriteLine(new string('-', 25));
                    Console.WriteLine("Current Page Index: " + results.Cursor.CurrentPageIndex);
                    Console.WriteLine("Estimated Result Count: " + results.Cursor.EstimatedResultsCount);
                    Console.WriteLine("More Results Url: " + results.Cursor.MoreResultsUrl);
                }
            }
            catch (Exception gse)
            {
                System.Console.WriteLine(gse.Message);
                System.Console.WriteLine(gse.StackTrace);
            }
        }

        public void runPatentSearch()
        {
            GPatentSearcher search = new GPatentSearcher();

            search.Query = SearchText;
            search.ResultsSize = GResultsSize.Large;

            try
            {
                Console.WriteLine("RUNNING PATENT SEARCH");
                Console.WriteLine(new string('-', 25));

                GPatentResultSet results = search.Search();

                foreach (GPatentResult result in results)
                {
                    Console.WriteLine("Title (No Formatting): " + result.TitleNoFormatting);
                    Console.WriteLine("Content: " + result.Content);
                    Console.WriteLine("Patent Number: " + result.PatentNumber);
                    Console.WriteLine("Patent Status: " + result.PatentStatus);
                    Console.WriteLine("Assignee: " + result.Assignee);
                    Console.WriteLine("Application Date: " + result.ApplicationDate);
                    Console.WriteLine("Url: " + result.Url);
                    Console.WriteLine("Unescaped Url: " + result.UnescapedUrl);
                    Console.WriteLine("Thumbnail Url: " + result.ThumbnailUrl);
                    Console.WriteLine();
                }

                Console.WriteLine(new string('-', 25));
                Console.WriteLine("Current Page Index: " + results.Cursor.CurrentPageIndex);
                Console.WriteLine("Estimated Result Count: " + results.Cursor.EstimatedResultsCount);
                Console.WriteLine("More Results Url: " + results.Cursor.MoreResultsUrl);
            }
            catch (Exception gse)
            {
                System.Console.WriteLine(gse.Message);
                System.Console.WriteLine(gse.StackTrace);
            }
        }

        static void Main(string[] args)
        {
            string searchString = args.Length == 0 ? "TEST SEARCH" : args[0];

            Program program = new Program();

            program.SearchText = searchString;

            program.runWebSearch();

            program.runImageSearch();

            program.runNewsSearch();

            program.runVideoSearch();

            program.runBlogSearch();

            program.runBookSearch();

            program.runLocalSearch();

            program.runPatentSearch();

            System.Console.ReadLine();
        }
    }
}
