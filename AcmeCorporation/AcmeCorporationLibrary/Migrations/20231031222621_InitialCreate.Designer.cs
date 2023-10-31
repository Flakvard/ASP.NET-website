﻿// <auto-generated />
using System;
using AcmeCorporationLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcmeCorporationLibrary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231031222621_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AcmeCorporationLibrary.Models.SerialNumberModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("ConsumeTimes")
                        .HasColumnType("bigint");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SerialNumbers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConsumeTimes = 2L,
                            Guid = "681ca54e-2184-441a-9d2a-92ed7426bc35",
                            IsActive = true
                        },
                        new
                        {
                            Id = 2,
                            ConsumeTimes = 2L,
                            Guid = "731b1ec0-cd5b-46db-9da2-b3324f3e1e1b",
                            IsActive = true
                        },
                        new
                        {
                            Id = 3,
                            ConsumeTimes = 2L,
                            Guid = "b8aa8726-90f7-4772-bcb4-56e25738447e",
                            IsActive = true
                        },
                        new
                        {
                            Id = 4,
                            ConsumeTimes = 2L,
                            Guid = "1d7c6296-e8d5-4e73-aa92-446a6b0505d0",
                            IsActive = true
                        },
                        new
                        {
                            Id = 5,
                            ConsumeTimes = 2L,
                            Guid = "fa015e4d-4008-422a-8064-05d2ad3953ff",
                            IsActive = true
                        },
                        new
                        {
                            Id = 6,
                            ConsumeTimes = 2L,
                            Guid = "668bf062-31f2-49d7-9e42-e7a3e0bbb3c0",
                            IsActive = true
                        },
                        new
                        {
                            Id = 7,
                            ConsumeTimes = 2L,
                            Guid = "5dddee3d-929d-474c-ae71-1505850f2b26",
                            IsActive = true
                        },
                        new
                        {
                            Id = 8,
                            ConsumeTimes = 2L,
                            Guid = "5cc07891-e60e-4fc7-8431-f72fd18e3eef",
                            IsActive = true
                        },
                        new
                        {
                            Id = 9,
                            ConsumeTimes = 2L,
                            Guid = "7b78b80e-b8b7-4491-a81f-55b2afd382bf",
                            IsActive = true
                        },
                        new
                        {
                            Id = 10,
                            ConsumeTimes = 2L,
                            Guid = "30506ac0-f0cb-4eb8-9fa1-f77dc7dff987",
                            IsActive = true
                        },
                        new
                        {
                            Id = 11,
                            ConsumeTimes = 2L,
                            Guid = "317300a1-b319-41f7-b8b6-06c52f4ca1c4",
                            IsActive = true
                        },
                        new
                        {
                            Id = 12,
                            ConsumeTimes = 2L,
                            Guid = "01621e8c-7fcf-41bd-9b6b-d1126d3aef6e",
                            IsActive = true
                        },
                        new
                        {
                            Id = 13,
                            ConsumeTimes = 2L,
                            Guid = "884302fa-4912-46ca-9b11-839fa5670e2d",
                            IsActive = true
                        },
                        new
                        {
                            Id = 14,
                            ConsumeTimes = 2L,
                            Guid = "359542c5-1b9c-4d90-9299-f5dcc7d92803",
                            IsActive = true
                        },
                        new
                        {
                            Id = 15,
                            ConsumeTimes = 2L,
                            Guid = "7027feba-4c44-4a4e-895f-d5c846d1398f",
                            IsActive = true
                        },
                        new
                        {
                            Id = 16,
                            ConsumeTimes = 2L,
                            Guid = "1992a924-fda1-4ee5-9808-f9ad9fae940b",
                            IsActive = true
                        },
                        new
                        {
                            Id = 17,
                            ConsumeTimes = 2L,
                            Guid = "3d5c6b66-9094-4242-b9d3-87245f097a1d",
                            IsActive = true
                        },
                        new
                        {
                            Id = 18,
                            ConsumeTimes = 2L,
                            Guid = "b0348df5-2615-4ca0-8812-df15473dfc25",
                            IsActive = true
                        },
                        new
                        {
                            Id = 19,
                            ConsumeTimes = 2L,
                            Guid = "6d1154e6-ef7d-45b3-9187-aa824b780bf2",
                            IsActive = true
                        },
                        new
                        {
                            Id = 20,
                            ConsumeTimes = 2L,
                            Guid = "21a4774f-321c-4edf-9a96-1d342bfd7a08",
                            IsActive = true
                        },
                        new
                        {
                            Id = 21,
                            ConsumeTimes = 2L,
                            Guid = "f6b8b362-cf49-406f-981d-237755b0fd69",
                            IsActive = true
                        },
                        new
                        {
                            Id = 22,
                            ConsumeTimes = 2L,
                            Guid = "16b95745-c762-4611-838e-e90aba28673f",
                            IsActive = true
                        },
                        new
                        {
                            Id = 23,
                            ConsumeTimes = 2L,
                            Guid = "11610fbd-deb2-4c51-84d2-a1f322ba67a0",
                            IsActive = true
                        },
                        new
                        {
                            Id = 24,
                            ConsumeTimes = 2L,
                            Guid = "42d763a6-8577-4bd4-bd4a-a1b4594f8130",
                            IsActive = true
                        },
                        new
                        {
                            Id = 25,
                            ConsumeTimes = 2L,
                            Guid = "4bccc3ed-d3bd-49b7-88b3-4c17634cc4a3",
                            IsActive = true
                        },
                        new
                        {
                            Id = 26,
                            ConsumeTimes = 2L,
                            Guid = "4b786cbc-79a5-4057-8db3-d5251f9cd9b2",
                            IsActive = true
                        },
                        new
                        {
                            Id = 27,
                            ConsumeTimes = 2L,
                            Guid = "6001229c-e85d-45aa-a691-956698b61b50",
                            IsActive = true
                        },
                        new
                        {
                            Id = 28,
                            ConsumeTimes = 2L,
                            Guid = "7e386580-07c8-4cf4-93fa-5ecf63435022",
                            IsActive = true
                        },
                        new
                        {
                            Id = 29,
                            ConsumeTimes = 2L,
                            Guid = "7db8ae45-25f7-4561-9ea0-fd5039f5b7d5",
                            IsActive = true
                        },
                        new
                        {
                            Id = 30,
                            ConsumeTimes = 2L,
                            Guid = "4e2caec9-388c-4728-88b5-201d6ab66a1f",
                            IsActive = true
                        },
                        new
                        {
                            Id = 31,
                            ConsumeTimes = 2L,
                            Guid = "e8206532-254f-4046-b4b6-10bb97ea6a68",
                            IsActive = true
                        },
                        new
                        {
                            Id = 32,
                            ConsumeTimes = 2L,
                            Guid = "7f6ea2ee-0b55-4bc6-bd50-430a8e6ad844",
                            IsActive = true
                        },
                        new
                        {
                            Id = 33,
                            ConsumeTimes = 2L,
                            Guid = "42b14970-b273-41a8-90ec-d31f59daa869",
                            IsActive = true
                        },
                        new
                        {
                            Id = 34,
                            ConsumeTimes = 2L,
                            Guid = "31c79c30-1780-4391-a77f-cc0d744f214d",
                            IsActive = true
                        },
                        new
                        {
                            Id = 35,
                            ConsumeTimes = 2L,
                            Guid = "2ce86e4e-b96e-4284-b109-638cd9dbe1dc",
                            IsActive = true
                        },
                        new
                        {
                            Id = 36,
                            ConsumeTimes = 2L,
                            Guid = "9de488e9-d7f6-4fc0-a6f6-5d3a4430f6b3",
                            IsActive = true
                        },
                        new
                        {
                            Id = 37,
                            ConsumeTimes = 2L,
                            Guid = "2bfaaf88-1f66-4c4c-a32f-ddc262a11431",
                            IsActive = true
                        },
                        new
                        {
                            Id = 38,
                            ConsumeTimes = 2L,
                            Guid = "90c01119-3499-4633-a32f-0afbcc3ea32b",
                            IsActive = true
                        },
                        new
                        {
                            Id = 39,
                            ConsumeTimes = 2L,
                            Guid = "a41bf1d9-4a60-4451-a99b-2db09382a980",
                            IsActive = true
                        },
                        new
                        {
                            Id = 40,
                            ConsumeTimes = 2L,
                            Guid = "cfedf8de-ec49-423c-af5d-64163fd82470",
                            IsActive = true
                        },
                        new
                        {
                            Id = 41,
                            ConsumeTimes = 2L,
                            Guid = "475f1585-b195-4038-94ae-7ba54f6c3955",
                            IsActive = true
                        },
                        new
                        {
                            Id = 42,
                            ConsumeTimes = 2L,
                            Guid = "ff7625be-ce20-43eb-8b88-a0ab53a43754",
                            IsActive = true
                        },
                        new
                        {
                            Id = 43,
                            ConsumeTimes = 2L,
                            Guid = "176cb7bf-f5db-42d6-b8f0-83db6700910f",
                            IsActive = true
                        },
                        new
                        {
                            Id = 44,
                            ConsumeTimes = 2L,
                            Guid = "734136be-d007-4a78-a683-93e4d66b3ade",
                            IsActive = true
                        },
                        new
                        {
                            Id = 45,
                            ConsumeTimes = 2L,
                            Guid = "ecc24f40-2aa8-4ab6-9d1d-572cdd1e1d69",
                            IsActive = true
                        },
                        new
                        {
                            Id = 46,
                            ConsumeTimes = 2L,
                            Guid = "f9ab15d9-bfa6-408f-9bb1-aa8ffd55a163",
                            IsActive = true
                        },
                        new
                        {
                            Id = 47,
                            ConsumeTimes = 2L,
                            Guid = "a6a0b9f7-e451-445e-8cad-6dee82583c1b",
                            IsActive = true
                        },
                        new
                        {
                            Id = 48,
                            ConsumeTimes = 2L,
                            Guid = "35940faa-1c5b-4416-b1b8-f0f3da02d517",
                            IsActive = true
                        },
                        new
                        {
                            Id = 49,
                            ConsumeTimes = 2L,
                            Guid = "1f6cde58-bdf7-4e9b-82e9-0910a3fc2695",
                            IsActive = true
                        },
                        new
                        {
                            Id = 50,
                            ConsumeTimes = 2L,
                            Guid = "79a2b215-b119-45dc-ae02-4b9e37d46e4b",
                            IsActive = true
                        },
                        new
                        {
                            Id = 51,
                            ConsumeTimes = 2L,
                            Guid = "0ce1ca0b-8c44-42fa-9543-2fe1ef8d9722",
                            IsActive = true
                        },
                        new
                        {
                            Id = 52,
                            ConsumeTimes = 2L,
                            Guid = "12a05b95-b342-4612-8409-d693a4b8a6d5",
                            IsActive = true
                        },
                        new
                        {
                            Id = 53,
                            ConsumeTimes = 2L,
                            Guid = "13333f1a-6fa9-4b16-b276-d59aa7c10374",
                            IsActive = true
                        },
                        new
                        {
                            Id = 54,
                            ConsumeTimes = 2L,
                            Guid = "94e90d31-1ea5-4c7b-9db4-9af8c41ca25d",
                            IsActive = true
                        },
                        new
                        {
                            Id = 55,
                            ConsumeTimes = 2L,
                            Guid = "8e0a51f6-2663-4201-ac7c-cb7987b90c6a",
                            IsActive = true
                        },
                        new
                        {
                            Id = 56,
                            ConsumeTimes = 2L,
                            Guid = "1de6b03e-b15e-414e-8e0c-4083570f32a6",
                            IsActive = true
                        },
                        new
                        {
                            Id = 57,
                            ConsumeTimes = 2L,
                            Guid = "6bc8eca7-e2df-4f4a-b12b-2128fc11e345",
                            IsActive = true
                        },
                        new
                        {
                            Id = 58,
                            ConsumeTimes = 2L,
                            Guid = "34d95f57-3f0e-4cb8-b82e-67135a787362",
                            IsActive = true
                        },
                        new
                        {
                            Id = 59,
                            ConsumeTimes = 2L,
                            Guid = "f106f536-e114-46a7-b933-625e75b7b811",
                            IsActive = true
                        },
                        new
                        {
                            Id = 60,
                            ConsumeTimes = 2L,
                            Guid = "68362832-04f8-4556-815b-f60c4d867d85",
                            IsActive = true
                        },
                        new
                        {
                            Id = 61,
                            ConsumeTimes = 2L,
                            Guid = "a07e4247-ab46-46e8-a29c-7e34ae36e4db",
                            IsActive = true
                        },
                        new
                        {
                            Id = 62,
                            ConsumeTimes = 2L,
                            Guid = "f660ccac-1df9-4e07-bfd9-d92394bed66d",
                            IsActive = true
                        },
                        new
                        {
                            Id = 63,
                            ConsumeTimes = 2L,
                            Guid = "e821d130-aa11-47a6-984a-0f3d3e054b23",
                            IsActive = true
                        },
                        new
                        {
                            Id = 64,
                            ConsumeTimes = 2L,
                            Guid = "df07e3d5-94a6-4c00-bbf8-de0c0f623286",
                            IsActive = true
                        },
                        new
                        {
                            Id = 65,
                            ConsumeTimes = 2L,
                            Guid = "1ab29163-5589-470b-8b22-08c16c4dc77b",
                            IsActive = true
                        },
                        new
                        {
                            Id = 66,
                            ConsumeTimes = 2L,
                            Guid = "ea08c54e-b3f0-4a98-9be3-d5cf332f4d99",
                            IsActive = true
                        },
                        new
                        {
                            Id = 67,
                            ConsumeTimes = 2L,
                            Guid = "82ceade0-0ac2-4d42-815a-e50f70c99ebb",
                            IsActive = true
                        },
                        new
                        {
                            Id = 68,
                            ConsumeTimes = 2L,
                            Guid = "698c2af6-42fa-4906-9204-2f347ae08ff7",
                            IsActive = true
                        },
                        new
                        {
                            Id = 69,
                            ConsumeTimes = 2L,
                            Guid = "018318c1-f6bb-48c1-acde-55f3acc2e108",
                            IsActive = true
                        },
                        new
                        {
                            Id = 70,
                            ConsumeTimes = 2L,
                            Guid = "669e3ccc-d92b-40fe-a8c6-920b33de7f19",
                            IsActive = true
                        },
                        new
                        {
                            Id = 71,
                            ConsumeTimes = 2L,
                            Guid = "3cd351f1-7a0a-4f08-b5d1-0159016cf360",
                            IsActive = true
                        },
                        new
                        {
                            Id = 72,
                            ConsumeTimes = 2L,
                            Guid = "6be18039-a864-46ca-9e11-02e4d1985abe",
                            IsActive = true
                        },
                        new
                        {
                            Id = 73,
                            ConsumeTimes = 2L,
                            Guid = "eadcda16-ac7e-474f-abe4-2366850c97e5",
                            IsActive = true
                        },
                        new
                        {
                            Id = 74,
                            ConsumeTimes = 2L,
                            Guid = "53a79397-561e-453e-aa4c-19305834b754",
                            IsActive = true
                        },
                        new
                        {
                            Id = 75,
                            ConsumeTimes = 2L,
                            Guid = "2432b8c7-3c7d-4e5b-80f9-12bccafb9266",
                            IsActive = true
                        },
                        new
                        {
                            Id = 76,
                            ConsumeTimes = 2L,
                            Guid = "0738adc7-9fff-40a5-a231-5329ad08ad65",
                            IsActive = true
                        },
                        new
                        {
                            Id = 77,
                            ConsumeTimes = 2L,
                            Guid = "1fa5fb71-069f-4086-87c0-0118263ee482",
                            IsActive = true
                        },
                        new
                        {
                            Id = 78,
                            ConsumeTimes = 2L,
                            Guid = "af2e4061-b59d-411d-86d1-29458ef146fd",
                            IsActive = true
                        },
                        new
                        {
                            Id = 79,
                            ConsumeTimes = 2L,
                            Guid = "f6e72248-7cce-4370-8d7c-71ad733708de",
                            IsActive = true
                        },
                        new
                        {
                            Id = 80,
                            ConsumeTimes = 2L,
                            Guid = "87ff47d0-0141-4ece-b0e4-0523bdf52f4b",
                            IsActive = true
                        },
                        new
                        {
                            Id = 81,
                            ConsumeTimes = 2L,
                            Guid = "7288f0bb-f28a-4369-b2a6-d549a629ad2a",
                            IsActive = true
                        },
                        new
                        {
                            Id = 82,
                            ConsumeTimes = 2L,
                            Guid = "e006f007-5fa0-4696-b019-129c6ebe1bd6",
                            IsActive = true
                        },
                        new
                        {
                            Id = 83,
                            ConsumeTimes = 2L,
                            Guid = "48c75674-efba-432f-bfae-1d1db07b3627",
                            IsActive = true
                        },
                        new
                        {
                            Id = 84,
                            ConsumeTimes = 2L,
                            Guid = "5efc14a9-ce59-4821-9036-2b5802bf4ac2",
                            IsActive = true
                        },
                        new
                        {
                            Id = 85,
                            ConsumeTimes = 2L,
                            Guid = "c30fc5c1-f54b-46d9-8759-18542a29e8b4",
                            IsActive = true
                        },
                        new
                        {
                            Id = 86,
                            ConsumeTimes = 2L,
                            Guid = "56b7edf3-dec8-4e75-9779-b20bad38ca81",
                            IsActive = true
                        },
                        new
                        {
                            Id = 87,
                            ConsumeTimes = 2L,
                            Guid = "d23c7574-818c-4d10-8b87-1bc2212c41bb",
                            IsActive = true
                        },
                        new
                        {
                            Id = 88,
                            ConsumeTimes = 2L,
                            Guid = "ab76d76f-e218-4bbe-a44f-2a093e65af2a",
                            IsActive = true
                        },
                        new
                        {
                            Id = 89,
                            ConsumeTimes = 2L,
                            Guid = "e4593067-60f9-412e-94d1-673a25826f3f",
                            IsActive = true
                        },
                        new
                        {
                            Id = 90,
                            ConsumeTimes = 2L,
                            Guid = "19a2d5d8-755c-4d6e-881e-e20b8e7eba36",
                            IsActive = true
                        },
                        new
                        {
                            Id = 91,
                            ConsumeTimes = 2L,
                            Guid = "00b5d2ad-af7b-4073-aff3-47305d2011f3",
                            IsActive = true
                        },
                        new
                        {
                            Id = 92,
                            ConsumeTimes = 2L,
                            Guid = "7c536f87-1b49-46ac-83d8-740a896bc6ca",
                            IsActive = true
                        },
                        new
                        {
                            Id = 93,
                            ConsumeTimes = 2L,
                            Guid = "3431f3fe-7b57-40d8-8ba6-9e6d24369b24",
                            IsActive = true
                        },
                        new
                        {
                            Id = 94,
                            ConsumeTimes = 2L,
                            Guid = "72932df0-5b52-44ad-96d3-f4c6e6f5d563",
                            IsActive = true
                        },
                        new
                        {
                            Id = 95,
                            ConsumeTimes = 2L,
                            Guid = "f1a59fdc-7b39-4341-a6b7-6d79ae128642",
                            IsActive = true
                        },
                        new
                        {
                            Id = 96,
                            ConsumeTimes = 2L,
                            Guid = "725671bb-33d3-4d08-938a-f283e5ffca43",
                            IsActive = true
                        },
                        new
                        {
                            Id = 97,
                            ConsumeTimes = 2L,
                            Guid = "b50bbfa4-dc4c-4664-80e8-b2b91f9f79ba",
                            IsActive = true
                        },
                        new
                        {
                            Id = 98,
                            ConsumeTimes = 2L,
                            Guid = "8371a823-4a85-41e6-97fe-44223d655f7d",
                            IsActive = true
                        },
                        new
                        {
                            Id = 99,
                            ConsumeTimes = 2L,
                            Guid = "f53e128d-4031-400e-b86e-64346f9f2f84",
                            IsActive = true
                        },
                        new
                        {
                            Id = 100,
                            ConsumeTimes = 2L,
                            Guid = "afb6b3ca-48b2-4ea7-8233-d88b8387f848",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("AcmeCorporationLibrary.Models.SubmissionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOver18")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductSerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Submission");
                });
#pragma warning restore 612, 618
        }
    }
}
