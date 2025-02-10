﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoListApp.WebApi.Repository;

#nullable disable

namespace TodoListApp.WebApi.Migrations
{
    [DbContext(typeof(TodoListDbContext))]
    [Migration("20250210164826_EntitiesV4")]
    partial class EntitiesV4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TagEntityTaskEntity", b =>
                {
                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.Property<int>("TasksId")
                        .HasColumnType("int");

                    b.HasKey("TagsId", "TasksId");

                    b.HasIndex("TasksId");

                    b.ToTable("TagEntityTaskEntity");
                });

            modelBuilder.Entity("TodoListApp.WebApi.Repository.Entities.CommentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("comment");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("task_id");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("comment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Comment1",
                            TaskId = 1
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Comment2",
                            TaskId = 1
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Comment3",
                            TaskId = 1
                        });
                });

            modelBuilder.Entity("TodoListApp.WebApi.Repository.Entities.StatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.HasKey("Id");

                    b.ToTable("task_status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Not Started",
                            IsActive = true
                        },
                        new
                        {
                            Id = 2,
                            Description = "In Progess",
                            IsActive = true
                        },
                        new
                        {
                            Id = 3,
                            Description = "Completed",
                            IsActive = false
                        });
                });

            modelBuilder.Entity("TodoListApp.WebApi.Repository.Entities.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "TagDescription1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "TagDescription2"
                        });
                });

            modelBuilder.Entity("TodoListApp.WebApi.Repository.Entities.TaskEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date")
                        .HasColumnName("created_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("date")
                        .HasColumnName("due_date");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("task_status_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<int?>("TodoListId")
                        .HasColumnType("int")
                        .HasColumnName("todolist_id");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("TodoListId");

                    b.ToTable("task");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1923),
                            Description = "TaskDescription1",
                            DueDate = new DateTime(2025, 2, 9, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1949),
                            StatusId = 1,
                            Title = "Task1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1952),
                            Description = "TaskDescription2",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1953),
                            StatusId = 1,
                            Title = "Task2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1955),
                            Description = "TaskDescription3",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1957),
                            StatusId = 1,
                            Title = "Task3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1959),
                            Description = "TaskDescription4",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1960),
                            StatusId = 1,
                            Title = "Task4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1963),
                            Description = "TaskDescription5",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1964),
                            StatusId = 1,
                            Title = "Task5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1966),
                            Description = "TaskDescription6",
                            DueDate = new DateTime(2025, 2, 9, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1968),
                            StatusId = 1,
                            Title = "Task6"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1970),
                            Description = "TaskDescription7",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1971),
                            StatusId = 1,
                            Title = "Task7"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1973),
                            Description = "TaskDescription8",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1975),
                            StatusId = 1,
                            Title = "Task8"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1977),
                            Description = "TaskDescription9",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1978),
                            StatusId = 1,
                            Title = "Task9"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1981),
                            Description = "TaskDescription10",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1982),
                            StatusId = 1,
                            Title = "Task10"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1984),
                            Description = "TaskDescription11",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1986),
                            StatusId = 1,
                            Title = "Task11"
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1988),
                            Description = "TaskDescription12",
                            DueDate = new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1989),
                            StatusId = 1,
                            Title = "Task12"
                        });
                });

            modelBuilder.Entity("TodoListApp.WebApi.Repository.Entities.TodoListEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("todo_list");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "TodoListDescription1",
                            Title = "TodoList1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "TodoListDescription2",
                            Title = "TodoList2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "TodoListDescription3",
                            Title = "TodoList3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "TodoListDescription4",
                            Title = "TodoList4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "TodoListDescription5",
                            Title = "TodoList5"
                        },
                        new
                        {
                            Id = 6,
                            Description = "TodoListDescription6",
                            Title = "TodoList6"
                        },
                        new
                        {
                            Id = 7,
                            Description = "TodoListDescription7",
                            Title = "TodoList7"
                        },
                        new
                        {
                            Id = 8,
                            Description = "TodoListDescription8",
                            Title = "TodoList8"
                        },
                        new
                        {
                            Id = 9,
                            Description = "TodoListDescription9",
                            Title = "TodoList9"
                        },
                        new
                        {
                            Id = 10,
                            Description = "TodoListDescription10",
                            Title = "TodoList10"
                        },
                        new
                        {
                            Id = 11,
                            Description = "TodoListDescription11",
                            Title = "TodoList11"
                        },
                        new
                        {
                            Id = 12,
                            Description = "TodoListDescription12",
                            Title = "TodoList12"
                        });
                });

            modelBuilder.Entity("TagEntityTaskEntity", b =>
                {
                    b.HasOne("TodoListApp.WebApi.Repository.Entities.TagEntity", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TodoListApp.WebApi.Repository.Entities.TaskEntity", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TodoListApp.WebApi.Repository.Entities.CommentEntity", b =>
                {
                    b.HasOne("TodoListApp.WebApi.Repository.Entities.TaskEntity", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TodoListApp.WebApi.Repository.Entities.TaskEntity", b =>
                {
                    b.HasOne("TodoListApp.WebApi.Repository.Entities.StatusEntity", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TodoListApp.WebApi.Repository.Entities.TodoListEntity", "TodoList")
                        .WithMany("Task")
                        .HasForeignKey("TodoListId");

                    b.Navigation("Status");

                    b.Navigation("TodoList");
                });

            modelBuilder.Entity("TodoListApp.WebApi.Repository.Entities.TodoListEntity", b =>
                {
                    b.Navigation("Task");
                });
#pragma warning restore 612, 618
        }
    }
}
