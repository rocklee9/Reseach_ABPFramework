$(function () {

    var l = abp.localization.getResource('Student');

    var createModal = new abp.ModalManager(abp.appPath + 'Class/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Class/EditModal');

    var dataTable = $('#ClassTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(acme.bookStore.book.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('StudentDeletionConfirmationMessage', data.record.name);
                                },
                                action: function (data) {
                                    acme.bookStore.book
                                        .delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            { data: "Name" },
           
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewClassButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});