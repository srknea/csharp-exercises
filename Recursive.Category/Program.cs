using Microsoft.EntityFrameworkCore;
using Recursive.Category.DAL;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var allCategoriesWithChildren = GetAllCategoriesWithChildren(_context);

    PrintCategoriesAsTree(allCategoriesWithChildren, "");

    static void PrintCategoriesAsTree(List<Category> categories, string prefix)
    {
        foreach (var category in categories)
        {
            Console.WriteLine(prefix + category.Name);
            PrintCategoriesAsTree(category.Children, prefix + "   ");
        }
    }
}

static List<Category> GetAllCategoriesWithChildren(AppDbContext context)
{
    // Tüm kök kategorileri çekme (ParentId null olanlar)
    var rootCategories = context.Categories
        .Include(c => c.Children)
        .Where(c => c.ParentId == null)
        .ToList();

    // Kök kategorilerin alt kategorilerini recursive (tekrarlanan) bir şekilde çekme
    foreach (var rootCategory in rootCategories)
    {
        rootCategory.Children = GetChildrenRecursive(context, rootCategory.Id);
    }

    return rootCategories;
}

static List<Category> GetChildrenRecursive(AppDbContext context, int parentId)
{
    var children = context.Categories
        .Include(c => c.Children)
        .Where(c => c.ParentId == parentId)
        .ToList();

    foreach (var child in children)
    {
        child.Children = GetChildrenRecursive(context, child.Id);
    }

    return children;
}

Console.ReadKey();