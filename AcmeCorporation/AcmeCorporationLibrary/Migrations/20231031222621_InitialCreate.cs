using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AcmeCorporationLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SerialNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ConsumeTimes = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Submission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOver18 = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submission", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "ConsumeTimes", "Guid", "IsActive" },
                values: new object[,]
                {
                    { 1, 2L, "681ca54e-2184-441a-9d2a-92ed7426bc35", true },
                    { 2, 2L, "731b1ec0-cd5b-46db-9da2-b3324f3e1e1b", true },
                    { 3, 2L, "b8aa8726-90f7-4772-bcb4-56e25738447e", true },
                    { 4, 2L, "1d7c6296-e8d5-4e73-aa92-446a6b0505d0", true },
                    { 5, 2L, "fa015e4d-4008-422a-8064-05d2ad3953ff", true },
                    { 6, 2L, "668bf062-31f2-49d7-9e42-e7a3e0bbb3c0", true },
                    { 7, 2L, "5dddee3d-929d-474c-ae71-1505850f2b26", true },
                    { 8, 2L, "5cc07891-e60e-4fc7-8431-f72fd18e3eef", true },
                    { 9, 2L, "7b78b80e-b8b7-4491-a81f-55b2afd382bf", true },
                    { 10, 2L, "30506ac0-f0cb-4eb8-9fa1-f77dc7dff987", true },
                    { 11, 2L, "317300a1-b319-41f7-b8b6-06c52f4ca1c4", true },
                    { 12, 2L, "01621e8c-7fcf-41bd-9b6b-d1126d3aef6e", true },
                    { 13, 2L, "884302fa-4912-46ca-9b11-839fa5670e2d", true },
                    { 14, 2L, "359542c5-1b9c-4d90-9299-f5dcc7d92803", true },
                    { 15, 2L, "7027feba-4c44-4a4e-895f-d5c846d1398f", true },
                    { 16, 2L, "1992a924-fda1-4ee5-9808-f9ad9fae940b", true },
                    { 17, 2L, "3d5c6b66-9094-4242-b9d3-87245f097a1d", true },
                    { 18, 2L, "b0348df5-2615-4ca0-8812-df15473dfc25", true },
                    { 19, 2L, "6d1154e6-ef7d-45b3-9187-aa824b780bf2", true },
                    { 20, 2L, "21a4774f-321c-4edf-9a96-1d342bfd7a08", true },
                    { 21, 2L, "f6b8b362-cf49-406f-981d-237755b0fd69", true },
                    { 22, 2L, "16b95745-c762-4611-838e-e90aba28673f", true },
                    { 23, 2L, "11610fbd-deb2-4c51-84d2-a1f322ba67a0", true },
                    { 24, 2L, "42d763a6-8577-4bd4-bd4a-a1b4594f8130", true },
                    { 25, 2L, "4bccc3ed-d3bd-49b7-88b3-4c17634cc4a3", true },
                    { 26, 2L, "4b786cbc-79a5-4057-8db3-d5251f9cd9b2", true },
                    { 27, 2L, "6001229c-e85d-45aa-a691-956698b61b50", true },
                    { 28, 2L, "7e386580-07c8-4cf4-93fa-5ecf63435022", true },
                    { 29, 2L, "7db8ae45-25f7-4561-9ea0-fd5039f5b7d5", true },
                    { 30, 2L, "4e2caec9-388c-4728-88b5-201d6ab66a1f", true },
                    { 31, 2L, "e8206532-254f-4046-b4b6-10bb97ea6a68", true },
                    { 32, 2L, "7f6ea2ee-0b55-4bc6-bd50-430a8e6ad844", true },
                    { 33, 2L, "42b14970-b273-41a8-90ec-d31f59daa869", true },
                    { 34, 2L, "31c79c30-1780-4391-a77f-cc0d744f214d", true },
                    { 35, 2L, "2ce86e4e-b96e-4284-b109-638cd9dbe1dc", true },
                    { 36, 2L, "9de488e9-d7f6-4fc0-a6f6-5d3a4430f6b3", true },
                    { 37, 2L, "2bfaaf88-1f66-4c4c-a32f-ddc262a11431", true },
                    { 38, 2L, "90c01119-3499-4633-a32f-0afbcc3ea32b", true },
                    { 39, 2L, "a41bf1d9-4a60-4451-a99b-2db09382a980", true },
                    { 40, 2L, "cfedf8de-ec49-423c-af5d-64163fd82470", true },
                    { 41, 2L, "475f1585-b195-4038-94ae-7ba54f6c3955", true },
                    { 42, 2L, "ff7625be-ce20-43eb-8b88-a0ab53a43754", true },
                    { 43, 2L, "176cb7bf-f5db-42d6-b8f0-83db6700910f", true },
                    { 44, 2L, "734136be-d007-4a78-a683-93e4d66b3ade", true },
                    { 45, 2L, "ecc24f40-2aa8-4ab6-9d1d-572cdd1e1d69", true },
                    { 46, 2L, "f9ab15d9-bfa6-408f-9bb1-aa8ffd55a163", true },
                    { 47, 2L, "a6a0b9f7-e451-445e-8cad-6dee82583c1b", true },
                    { 48, 2L, "35940faa-1c5b-4416-b1b8-f0f3da02d517", true },
                    { 49, 2L, "1f6cde58-bdf7-4e9b-82e9-0910a3fc2695", true },
                    { 50, 2L, "79a2b215-b119-45dc-ae02-4b9e37d46e4b", true },
                    { 51, 2L, "0ce1ca0b-8c44-42fa-9543-2fe1ef8d9722", true },
                    { 52, 2L, "12a05b95-b342-4612-8409-d693a4b8a6d5", true },
                    { 53, 2L, "13333f1a-6fa9-4b16-b276-d59aa7c10374", true },
                    { 54, 2L, "94e90d31-1ea5-4c7b-9db4-9af8c41ca25d", true },
                    { 55, 2L, "8e0a51f6-2663-4201-ac7c-cb7987b90c6a", true },
                    { 56, 2L, "1de6b03e-b15e-414e-8e0c-4083570f32a6", true },
                    { 57, 2L, "6bc8eca7-e2df-4f4a-b12b-2128fc11e345", true },
                    { 58, 2L, "34d95f57-3f0e-4cb8-b82e-67135a787362", true },
                    { 59, 2L, "f106f536-e114-46a7-b933-625e75b7b811", true },
                    { 60, 2L, "68362832-04f8-4556-815b-f60c4d867d85", true },
                    { 61, 2L, "a07e4247-ab46-46e8-a29c-7e34ae36e4db", true },
                    { 62, 2L, "f660ccac-1df9-4e07-bfd9-d92394bed66d", true },
                    { 63, 2L, "e821d130-aa11-47a6-984a-0f3d3e054b23", true },
                    { 64, 2L, "df07e3d5-94a6-4c00-bbf8-de0c0f623286", true },
                    { 65, 2L, "1ab29163-5589-470b-8b22-08c16c4dc77b", true },
                    { 66, 2L, "ea08c54e-b3f0-4a98-9be3-d5cf332f4d99", true },
                    { 67, 2L, "82ceade0-0ac2-4d42-815a-e50f70c99ebb", true },
                    { 68, 2L, "698c2af6-42fa-4906-9204-2f347ae08ff7", true },
                    { 69, 2L, "018318c1-f6bb-48c1-acde-55f3acc2e108", true },
                    { 70, 2L, "669e3ccc-d92b-40fe-a8c6-920b33de7f19", true },
                    { 71, 2L, "3cd351f1-7a0a-4f08-b5d1-0159016cf360", true },
                    { 72, 2L, "6be18039-a864-46ca-9e11-02e4d1985abe", true },
                    { 73, 2L, "eadcda16-ac7e-474f-abe4-2366850c97e5", true },
                    { 74, 2L, "53a79397-561e-453e-aa4c-19305834b754", true },
                    { 75, 2L, "2432b8c7-3c7d-4e5b-80f9-12bccafb9266", true },
                    { 76, 2L, "0738adc7-9fff-40a5-a231-5329ad08ad65", true },
                    { 77, 2L, "1fa5fb71-069f-4086-87c0-0118263ee482", true },
                    { 78, 2L, "af2e4061-b59d-411d-86d1-29458ef146fd", true },
                    { 79, 2L, "f6e72248-7cce-4370-8d7c-71ad733708de", true },
                    { 80, 2L, "87ff47d0-0141-4ece-b0e4-0523bdf52f4b", true },
                    { 81, 2L, "7288f0bb-f28a-4369-b2a6-d549a629ad2a", true },
                    { 82, 2L, "e006f007-5fa0-4696-b019-129c6ebe1bd6", true },
                    { 83, 2L, "48c75674-efba-432f-bfae-1d1db07b3627", true },
                    { 84, 2L, "5efc14a9-ce59-4821-9036-2b5802bf4ac2", true },
                    { 85, 2L, "c30fc5c1-f54b-46d9-8759-18542a29e8b4", true },
                    { 86, 2L, "56b7edf3-dec8-4e75-9779-b20bad38ca81", true },
                    { 87, 2L, "d23c7574-818c-4d10-8b87-1bc2212c41bb", true },
                    { 88, 2L, "ab76d76f-e218-4bbe-a44f-2a093e65af2a", true },
                    { 89, 2L, "e4593067-60f9-412e-94d1-673a25826f3f", true },
                    { 90, 2L, "19a2d5d8-755c-4d6e-881e-e20b8e7eba36", true },
                    { 91, 2L, "00b5d2ad-af7b-4073-aff3-47305d2011f3", true },
                    { 92, 2L, "7c536f87-1b49-46ac-83d8-740a896bc6ca", true },
                    { 93, 2L, "3431f3fe-7b57-40d8-8ba6-9e6d24369b24", true },
                    { 94, 2L, "72932df0-5b52-44ad-96d3-f4c6e6f5d563", true },
                    { 95, 2L, "f1a59fdc-7b39-4341-a6b7-6d79ae128642", true },
                    { 96, 2L, "725671bb-33d3-4d08-938a-f283e5ffca43", true },
                    { 97, 2L, "b50bbfa4-dc4c-4664-80e8-b2b91f9f79ba", true },
                    { 98, 2L, "8371a823-4a85-41e6-97fe-44223d655f7d", true },
                    { 99, 2L, "f53e128d-4031-400e-b86e-64346f9f2f84", true },
                    { 100, 2L, "afb6b3ca-48b2-4ea7-8233-d88b8387f848", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerialNumbers");

            migrationBuilder.DropTable(
                name: "Submission");
        }
    }
}
