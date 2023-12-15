$(function () {

    $("#BookFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#BookCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#BookFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/BookFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('BookStore');

    var service = acme.bookStore.books.book;
    var createModal = new abp.ModalManager(abp.appPath + 'Books/Book/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Books/Book/EditModal');

    var dataTable = $('#BookTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,//disable default searchbox
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('BookStore.Book.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('BookStore.Book.Delete'),
                                confirmMessage: function (data) {
                                    return l('BookDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('BookName'),
                data: "name"
            },
            {
                title: l('BookType'),
                data: "type"
            },
            {
                title: l('BookPublishDate'),
                data: "publishDate"
            },
            {
                title: l('BookPrice'),
                data: "price"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBookButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
