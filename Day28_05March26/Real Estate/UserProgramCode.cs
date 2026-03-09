using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Text;
using static Real_Estate.UserProgramCode;

namespace Real_Estate
{
	internal class UserProgramCode
	{
		public interface IRealEstateListing
		{
			int ID { get; set; }
			string Title { get; set; }
			string Description { get; set; }
			int Price { get; set; }
			string Location { get; set; }

		}

		public interface IRealEstateApp
		{
			void AddListing(IRealEstateListing listing);

			void RemoveListing(int ListingIDs);
			void UpdateListing(IRealEstateListing listing);
			List<IRealEstateListing> GetListings();
			List<IRealEstateListing> getGetListingsByLocation(string loc);
			List<IRealEstateListing> getListingByRange(int minPrice, int maxPrice);

		}

		public class RealEstateListing : IRealEstateListing
		{
			public int ID { get; set; }
			public string Title { get; set; }
			public string Description { get; set; }
			public int Price { get; set; }
			public string Location { get; set; }
			public RealEstateListing()
			{ }
			public RealEstateListing(int id, string title, string description, int price, string location)
			{
				ID = id;
				Title = title;
				Description = description;
				Price = price;
				Location = location;
			}
		}

		public class RealEstateApp : IRealEstateApp
		{
			private List<IRealEstateListing> listings = new List<IRealEstateListing>();
			public void AddListing(IRealEstateListing listing)
			{
				listings.Add(listing);
			}
			public void RemoveListing(int ListingIDs)
			{
				listings.RemoveAll(l => l.ID == ListingIDs);
			}
			public void UpdateListing(IRealEstateListing listing)
			{
				var existing = listings.FirstOrDefault(l => l.ID == listing.ID);

				if (existing != null)
				{
					existing.Title = listing.Title;
					existing.Description = listing.Description;
					existing.Price = listing.Price;
					existing.Location = listing.Location;
				}
			}
			public List<IRealEstateListing> GetListings()
			{
				return new List<IRealEstateListing>(listings);
			}
			public List<IRealEstateListing> getGetListingsByLocation(string loc)
			{
				return listings.Where(l => l.Location == loc).ToList();
			}
			public List<IRealEstateListing> getListingByRange(int minPrice, int maxPrice)
			{
				return listings.Where(l => l.Price >= minPrice && l.Price <= maxPrice).ToList();
			}
			public List<IRealEstateListing> GetListingsSortedByPrice()
			{
				return listings.OrderByDescending(l => l.Price).ToList();
			}
			public Dictionary<string, int> CountListingsByLocation()
			{
				return listings.GroupBy(l => l.Location).ToDictionary(g => g.Key, g => g.Count());
			}
			public Dictionary<string, List<IRealEstateListing>> GetListingsGroupedByLocation()
			{
				return listings.GroupBy(l => l.Location).ToDictionary(l => l.Key, l => l.ToList());
			}
			public List<string> GetUniqueLocations()
			{
				return listings.Select(l => l.Location).Distinct().ToList();
			}
			public bool ListingExists(int id)
			{
				return listings.Any(l => l.ID == id);
			}
			public double Expensive()
			{
				return listings.Max(p => p.Price);
			}
			public List<IRealEstateListing> GetTop3ExpensiveListings()
			{
				return listings.OrderByDescending(p=>p.Price).Take(3).ToList();
			}
			public Dictionary<string, double> GetAveragePriceByLocation()
			{
				return listings.GroupBy(l => l.Location).ToDictionary(k => k.Key, k => k.Average(p => p.Price));
			}
			public int CountExpensiveListings(double price)
			{
				return listings.Count(p => p.Price > price);
			}
			public IRealEstateListing GetMostExpensiveListing()
			{
				return listings.OrderByDescending(p => p.Price).FirstOrDefault();
			}
			public List<IRealEstateListing> GetListingsInPriceRange(double min, double max)
			{
				return listings.Where(p => p.Price >= min && p.Price <= max).ToList();
			}
			public List<string> GetLocationsWithHighAverage(double price)
			{
				return listings.GroupBy(l => l.Location).
								Where(a => a.Average(p => p.Price) > price).
								Select(l => l.Key).ToList();

			}
			public List<string> GetLocationsWithMoreThan(int count)
			{
				return listings.GroupBy(l => l.Location).
								Where(k => k.Count() > count).
								Select(l=>l.Key).ToList();
			}

		}
	}
}
