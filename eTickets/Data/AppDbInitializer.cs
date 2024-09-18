using eBooks.Data.Static;
using eBooks.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Data
{
    public class AppDbInitializer
    {
        //Seeding the database with test data
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //creating an application services scope
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Creating a reference to the AppDbContext file
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                //Making sure that the database is created
                context.Database.EnsureCreated();

                //Publisher
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            Name = "Sarasavi",
                            Logo = "https://ceylonpages.lk/wp-content/uploads/2020/05/Sarasavi_Cover-scaled.jpg",
                            Description = " Sarasavi Bookshop (Pvt) Ltd is truly a proper combination of the tradition and the modernity that brings the future to the present . Over the past 50 years, we have become a prestigious and leading network of bookshops in Sri Lanka, expanding our business activities both in terms of quality and quantity."
                        },
                        new Publisher()
                        {
                            Name = "M. D. GUNASENA",
                            Logo = "https://mdgunasena.com/wp-content/uploads/2021/06/email-logo.jpg",
                            Description = "Since 1913, M. D. GUNASENA has become an established household name that resonates in the hearts and minds of people, as a trusted brand synonymous with education."
                        },
                        new Publisher()
                        {
                            Name = "Makeen Books",
                            Logo = "https://www.seylan.lk/uploads/MAKEEN-BOOKS.jpg",
                            Description = "Makeen Books differentiates itself by being Sri Lanka's largest English Book Store besides being affordable, convenient and Variety to our customers."
                        },
                        new Publisher()
                        {
                            Name = "Penguin Books",
                            Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1c/Penguin_logo.svg/1200px-Penguin_logo.svg.png",
                            Description = "With nearly 2,000 titles, Penguin Classics represents a global bookshelf of the best works throughout history and across genres and disciplines."
                        },
                        new Publisher()
                        {
                            Name = "The Jam Fruit Tree Publications",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9ZJv_sHtGMZX-plu7VfLMvoVXP94Zr3bKlA&s",
                            Description = "We provide professional editing, proofreading, typesetting, layout, cover design and printing. The Jam Fruit Tree began in 2011 with the intention of providing authors with a platform to publish their works, backed by good editorial, high-qualit."
                        },
                    });
                    context.SaveChanges();
                }
                //Illustrators
                if (!context.Illustrators.Any())
                {
                    context.Illustrators.AddRange(new List<Illustrator>()
                    {
                        new Illustrator()
                        {
                            FullName = "Malika Favre",
                            Bio = "Malika Favre (born 14 December 1982) is a French illustrator and graphic artist based in Barcelona. Her style of works could be characterized by pure minimalism within Pop art and Op art, where it sometimes described as 'Pop Art meets Op Art'.",
                            ProfilePictureURL = "https://www.stirworld.com/images/see/3810_Malika_5.jpg?0"

                        },
                        new Illustrator()
                        {
                            FullName = "Richard Corben",
                            Bio = "Richard Corben (November 1, 1940 – December 2, 2020) was an American illustrator and comic book artist best known for his comics featured in Heavy Metal magazine, especially the Den series which was featured in the magazine's first film adaptation in 1981.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/en/d/d4/Richard_corben_at_his_studio.jpg"
                        },
                        new Illustrator()
                        {
                            FullName = "Beatrix Potter",
                            Bio = "Beatrix Potter (born July 28, 1866, South Kensington, Middlesex [now in Greater London], England—died December 22, 1943, Sawrey, Lancashire [now in Cumbria]) was an English author of children's books, who created Peter Rabbit, Jeremy Fisher, Jemima Puddle-Duck, Mrs. Tiggy-Winkle, and other animal characters.",
                            ProfilePictureURL = "https://cdn.britannica.com/92/25592-050-6A29FB3E/Beatrix-Potter-1913.jpg"
                        },
                        new Illustrator()
                        {
                            FullName = "Quentin Blake",
                            Bio = "Quentin Blake is an English children’s book illustrator and author. He has drawn illustrations for more than 300 books. He is best known for illustrating the books of Roald Dahl.",
                            ProfilePictureURL = "https://www.booktrust.org.uk/globalassets/images/childrens-laureate/former-laureates/quentin-blake-16x9.jpg?w=1200&h=675&quality=70&anchor=middlecenter"
                        },
                        new Illustrator()
                        {
                            FullName = "Jean Jullien",
                            Bio = "Jean Jullien is a French graphic artist living and working in Paris. Originally from Nantes, Jean completed a graphic design degree in Quimper before moving to London. He has since graduated from Central Saint Martins (2008) and from the Royal College of Art (2010).",
                            ProfilePictureURL = "https://www.designboom.com/wp-content/uploads/2014/11/jean_julien_01.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            FullName = "Jane Austen",
                            Bio = "Jane Austen (born December 16, 1775, Steventon, Hampshire, England—died July 18, 1817, Winchester, Hampshire) was an English writer who first gave the novel its distinctly modern character through her treatment of ordinary people in everyday life.",
                            ProfilePictureURL = "https://cdn.britannica.com/12/172012-050-DAA7CE6B/Jane-Austen-Cassandra-engraving-portrait-1810.jpg"

                        },
                        new Author()
                        {
                            FullName = "F. Scott Fitzgerald",
                            Bio = "F. Scott Fitzgerald was a 20th-century American short-story writer and novelist. Although he completed four novels and more than 150 short stories in his lifetime, he is perhaps best remembered for his third novel, The Great Gatsby (1925). The Great Gatsby is today widely considered “the great American novel.”",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/8/87/F._Scott_Fitzgerald_%281929_photo_portrait_by_Nickolas_Muray%29_Cropped.jpg"
                        },
                        new Author()
                        {
                            FullName = "J. K. Rowling",
                            Bio = "What is J.K. Rowling famous for? J.K. Rowling is the British author who created the popular and critically acclaimed Harry Potter series (seven books published between 1997 and 2007), about a lonely orphan who discovers that he is actually a wizard and enrolls in the Hogwarts School of Witchcraft and Wizardry.",
                            ProfilePictureURL = "https://www.jkrowling.com/wp-content/uploads/2022/05/J.K.-Rowling-2021-Photography-Debra-Hurford-Brown-scaled.jpg"
                        },
                        new Author()
                        {
                            FullName = "Harper Lee",
                            Bio = "Nelle Harper Lee (April 28, 1926 – February 19, 2016) was an American novelist whose 1960 novel To Kill a Mockingbird won the 1961 Pulitzer Prize and became a classic of modern American literature. She assisted her close friend Truman Capote in his research for the book In Cold Blood (1966).",
                            ProfilePictureURL = "https://hips.hearstapps.com/hmg-prod/images/gettyimages-50358657.jpg"
                        },
                        new Author()
                        {
                            FullName = "Herman Melville",
                            Bio = "Herman Melville (born August 1, 1819, New York City—died September 28, 1891, New York City) was an American novelist, short-story writer, and poet, best known for his novels of the sea, including his masterpiece, Moby Dick (1851).",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Herman_Melville_by_Joseph_O_Eaton.jpg/1200px-Herman_Melville_by_Joseph_O_Eaton.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>() 
                    {
                        new Book()
                        {
                            Name = "Harry Potter and the Philosopher's Stone",
                            Description = "Featuring vivid descriptions and an imaginative story line, it followed the adventures of the unlikely hero Harry Potter, a lonely orphan who discovers that he is actually a wizard and enrolls in the Hogwarts School of Witchcraft and Wizardry. The book received numerous awards, including the British Book Award.",
                            Price = 29.50,
                            ImageURL = "https://makeenbooks.com/upload/ga/9781526646651.jpg",
                            PublicationDate = DateTime.Now.AddDays(-3000),
                            PublisherId = 3,
                            AuthorId = 3,
                            BookCategory = BookCategory.Fantasy
                        },
                        new Book()
                        {
                            Name = "Pride and Prejudice",
                            Description = "Pride and Prejudice follows the turbulent relationship between Elizabeth Bennet, the daughter of a country gentleman, and Fitzwilliam Darcy, a rich aristocratic landowner. They must overcome the titular sins of pride and prejudice in order to fall in love and marry.",
                            Price = 19.50,
                            ImageURL = "https://cdn2.penguin.com.au/covers/original/9780141949055.jpg",
                            PublicationDate = DateTime.Now.AddDays(-1000),
                            PublisherId = 1,
                            AuthorId = 1,
                            BookCategory = BookCategory.Romance
                        },
                        new Book()
                        {
                            Name = "To Kill a Mockingbird",
                            Description = "To Kill a Mockingbird is a 1961 novel by Harper Lee. Set in small-town Alabama, the novel is a bildungsroman, or coming-of-age story, and chronicles the childhood of Scout and Jem Finch as their father Atticus defends a Black man falsely accused of rape. Scout and Jem are mocked by classmates for this.",
                            Price = 24.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/To_Kill_a_Mockingbird_%28first_edition_cover%29.jpg/1200px-To_Kill_a_Mockingbird_%28first_edition_cover%29.jpg",
                            PublicationDate = DateTime.Now.AddDays(-2000),
                            PublisherId = 4,
                            AuthorId = 4,
                            BookCategory = BookCategory.Novel
                        },
                        new Book()
                        {
                            Name = "The Great Gatsby",
                            Description = "The Great Gatsby, novel by American author F. Scott Fitzgerald, published in 1925. It tells the story of Jay Gatsby, a self-made millionaire, and his pursuit of Daisy Buchanan, a wealthy young woman whom he loved in his youth. Set in 1920s New York, the book is narrated by Nick Carraway.",
                            Price = 34.50,
                            ImageURL = "https://www.hachettebookgroup.com/wp-content/uploads/2020/06/9780762498130-3.jpg?w=640",
                            PublicationDate = DateTime.Now.AddDays(-4000),
                            PublisherId = 1,
                            AuthorId = 2,
                            BookCategory = BookCategory.Fantasy
                        },
                        new Book()
                        {
                            Name = "Harry Potter and the Prisoner of Azkaban",
                            Description = "Harry Potter & The Prisoner of Azkaban is about Harry's 3rd year at Hogwarts. Along with friends Ron and Hermione, Harry investigates the case of Sirius Black, an escaped prisoner from Azkaban, the wizard prison.",
                            Price = 14.50,
                            ImageURL = "https://m.media-amazon.com/images/I/812CcFkEPCL._AC_UF1000,1000_QL80_.jpg",
                            PublicationDate = DateTime.Now.AddDays(-300),
                            PublisherId = 1,
                            AuthorId = 3,
                            BookCategory = BookCategory.Fantasy
                        },
                        new Book()
                        {
                            Name = "Moby-Dick",
                            Description = "Herman Melville's Moby Dick is the story of Captain Ahab's self-destructive obsession with the white whale called Moby Dick. It is told through the narration of Ishmael, a sailor new to Ahab's ship, the Pequod. The plot of the novel follows Ahab's manic drive to kill the whale, even as it endangers his crew.",
                            Price = 44.50,
                            ImageURL = "https://images.booksense.com/images/994/172/9798735172994.jpg",
                            PublicationDate = DateTime.Now.AddDays(-1500),
                            PublisherId = 1,
                            AuthorId = 5,
                            BookCategory = BookCategory.Novel
                        }
                    });
                    context.SaveChanges();
                }
                //Illustrators & Books
                if (!context.Illustrators_Books.Any())
                {
                    //Creating the connection between Illustrators & Books
                    context.Illustrators_Books.AddRange(new List<Illustrator_Book>()
                    {
                        new Illustrator_Book()
                        {
                            IllustratorId = 1,
                            BookId = 1
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 3,
                            BookId = 1
                        },

                         new Illustrator_Book()
                        {
                            IllustratorId = 1,
                            BookId = 2
                        },
                         new Illustrator_Book()
                        {
                            IllustratorId = 4,
                            BookId = 2
                        },

                        new Illustrator_Book()
                        {
                            IllustratorId = 1,
                            BookId = 3
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 2,
                            BookId = 3
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 5,
                            BookId = 3
                        },


                        new Illustrator_Book()
                        {
                            IllustratorId = 2,
                            BookId = 4
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 3,
                            BookId = 4
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 4,
                            BookId = 4
                        },


                        new Illustrator_Book()
                        {
                            IllustratorId = 2,
                            BookId = 5
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 3,
                            BookId = 5
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 4,
                            BookId = 5
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 5,
                            BookId = 5
                        },


                        new Illustrator_Book()
                        {
                            IllustratorId = 3,
                            BookId = 6
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 4,
                            BookId = 6
                        },
                        new Illustrator_Book()
                        {
                            IllustratorId = 5,
                            BookId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@ebooks.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@ebooks.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
