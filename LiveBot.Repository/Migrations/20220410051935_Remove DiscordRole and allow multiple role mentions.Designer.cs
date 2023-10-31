// <auto-generated />
using System;
using LiveBot.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LiveBot.Repository.Migrations
{
    [DbContext(typeof(LiveBotDBContext))]
    [Migration("20220410051935_Remove DiscordRole and allow multiple role mentions")]
    partial class RemoveDiscordRoleandallowmultiplerolementions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Discord.DiscordChannel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<long?>("DiscordGuildId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("DiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DiscordGuildId");

                    b.ToTable("DiscordChannel");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Discord.DiscordGuild", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("DiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("IconUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsInBeta")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("DiscordGuild");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Discord.DiscordGuildConfig", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<decimal?>("AdminRoleDiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<long?>("DiscordChannelId")
                        .HasColumnType("bigint");

                    b.Property<long>("DiscordGuildId")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("MentionRoleDiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<decimal?>("MonitorRoleDiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DiscordChannelId");

                    b.HasIndex("DiscordGuildId")
                        .IsUnique();

                    b.ToTable("DiscordGuildConfig");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.MonitorAuth", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("AccessToken")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .HasColumnType("text");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("Expired")
                        .HasColumnType("boolean");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<int>("ServiceType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("MonitorAuth");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Streams.RoleToMention", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("DiscordRoleId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<long?>("StreamSubscriptionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("StreamSubscriptionId");

                    b.ToTable("RoleToMention");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Streams.StreamGame", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ServiceType")
                        .HasColumnType("integer");

                    b.Property<string>("SourceId")
                        .HasColumnType("text");

                    b.Property<string>("ThumbnailURL")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("StreamGame");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Streams.StreamNotification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("DiscordChannel_DiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("DiscordChannel_Name")
                        .HasColumnType("text");

                    b.Property<decimal>("DiscordGuild_DiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("DiscordGuild_Name")
                        .HasColumnType("text");

                    b.Property<decimal?>("DiscordMessage_DiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("DiscordRole_DiscordId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("DiscordRole_Name")
                        .HasColumnType("text");

                    b.Property<string>("Game_Name")
                        .HasColumnType("text");

                    b.Property<string>("Game_SourceID")
                        .HasColumnType("text");

                    b.Property<string>("Game_ThumbnailURL")
                        .HasColumnType("text");

                    b.Property<string>("LogMessage")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<int>("ServiceType")
                        .HasColumnType("integer");

                    b.Property<string>("Stream_SourceID")
                        .HasColumnType("text");

                    b.Property<DateTime>("Stream_StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Stream_StreamURL")
                        .HasColumnType("text");

                    b.Property<string>("Stream_ThumbnailURL")
                        .HasColumnType("text");

                    b.Property<string>("Stream_Title")
                        .HasColumnType("text");

                    b.Property<bool>("Success")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("User_AvatarURL")
                        .HasColumnType("text");

                    b.Property<string>("User_DisplayName")
                        .HasColumnType("text");

                    b.Property<string>("User_ProfileURL")
                        .HasColumnType("text");

                    b.Property<string>("User_SourceID")
                        .HasColumnType("text");

                    b.Property<string>("User_Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("StreamNotification");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Streams.StreamSubscription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<long?>("DiscordChannelId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DiscordGuildId")
                        .HasColumnType("bigint");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DiscordChannelId");

                    b.HasIndex("DiscordGuildId");

                    b.HasIndex("UserId");

                    b.ToTable("StreamSubscription");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Streams.StreamUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("AvatarURL")
                        .HasColumnType("text");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<string>("ProfileURL")
                        .HasColumnType("text");

                    b.Property<int>("ServiceType")
                        .HasColumnType("integer");

                    b.Property<string>("SourceID")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("StreamUser");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Discord.DiscordChannel", b =>
                {
                    b.HasOne("LiveBot.Core.Repository.Models.Discord.DiscordGuild", "DiscordGuild")
                        .WithMany("DiscordChannels")
                        .HasForeignKey("DiscordGuildId");

                    b.Navigation("DiscordGuild");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Discord.DiscordGuildConfig", b =>
                {
                    b.HasOne("LiveBot.Core.Repository.Models.Discord.DiscordChannel", "DiscordChannel")
                        .WithMany()
                        .HasForeignKey("DiscordChannelId");

                    b.HasOne("LiveBot.Core.Repository.Models.Discord.DiscordGuild", "DiscordGuild")
                        .WithOne("Config")
                        .HasForeignKey("LiveBot.Core.Repository.Models.Discord.DiscordGuildConfig", "DiscordGuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiscordChannel");

                    b.Navigation("DiscordGuild");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Streams.RoleToMention", b =>
                {
                    b.HasOne("LiveBot.Core.Repository.Models.Streams.StreamSubscription", "StreamSubscription")
                        .WithMany("RolesToMention")
                        .HasForeignKey("StreamSubscriptionId");

                    b.Navigation("StreamSubscription");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Streams.StreamSubscription", b =>
                {
                    b.HasOne("LiveBot.Core.Repository.Models.Discord.DiscordChannel", "DiscordChannel")
                        .WithMany("StreamSubscriptions")
                        .HasForeignKey("DiscordChannelId");

                    b.HasOne("LiveBot.Core.Repository.Models.Discord.DiscordGuild", "DiscordGuild")
                        .WithMany("StreamSubscriptions")
                        .HasForeignKey("DiscordGuildId");

                    b.HasOne("LiveBot.Core.Repository.Models.Streams.StreamUser", "User")
                        .WithMany("StreamSubscriptions")
                        .HasForeignKey("UserId");

                    b.Navigation("DiscordChannel");

                    b.Navigation("DiscordGuild");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Discord.DiscordChannel", b =>
                {
                    b.Navigation("StreamSubscriptions");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Discord.DiscordGuild", b =>
                {
                    b.Navigation("Config");

                    b.Navigation("DiscordChannels");

                    b.Navigation("StreamSubscriptions");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Streams.StreamSubscription", b =>
                {
                    b.Navigation("RolesToMention");
                });

            modelBuilder.Entity("LiveBot.Core.Repository.Models.Streams.StreamUser", b =>
                {
                    b.Navigation("StreamSubscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
