using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions;

public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStorePermissions.MyPermission1, L("Permission:MyPermission1"));

        var bookPermission = myGroup.AddPermission(BookStorePermissions.Book.Default, L("Permission:Book"));
        bookPermission.AddChild(BookStorePermissions.Book.Create, L("Permission:Create"));
        bookPermission.AddChild(BookStorePermissions.Book.Update, L("Permission:Update"));
        bookPermission.AddChild(BookStorePermissions.Book.Delete, L("Permission:Delete"));

        var categoryPermission = myGroup.AddPermission(BookStorePermissions.Category.Default, L("Permission:Category"));
        categoryPermission.AddChild(BookStorePermissions.Category.Create, L("Permission:Create"));
        categoryPermission.AddChild(BookStorePermissions.Category.Update, L("Permission:Update"));
        categoryPermission.AddChild(BookStorePermissions.Category.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreResource>(name);
    }
}
