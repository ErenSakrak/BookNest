using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookNest.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Created_Date", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "Updated_Date" },
                values: new object[,]
                {
                    { 1, null, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum.", "https://placehold.co/600x400", "Royal Villa", 4, 200.0, 550, null },
                    { 2, null, "Donec nec posuere tortor. Aenean quis condimentum arcu, non ultricies sapien. Etiam condimentum elementum commodo. Etiam pulvinar ante eget iaculis efficitur.", "https://placehold.co/600x401", "Premium Pool Villa", 4, 300.0, 650, null },
                    { 3, null, "Vestibulum hendrerit diam eget est iaculis finibus. Suspendisse nec metus sed metus posuere porttitor. Quisque sed leo sapien. Phasellus hendrerit hendrerit rutrum. Donec ut porta neque. Quisque condimentum blandit pretium.", "https://placehold.co/600x402", "Luxury Pool Villa", 4, 450.0, 750, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
