$(function () {

    var l = abp.localization.getResource('MarketWatch');

    var service = marketWatch.simulation.backtestHistory;
    var createModal = new abp.ModalManager(abp.appPath + 'Simulation/BacktestHistory/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Simulation/BacktestHistory/EditModal');

    var dataTable = $('#BacktestHistoryTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: true,
        autoWidth: true,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('MarketWatch.BacktestHistory.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('MarketWatch.BacktestHistory.Delete'),
                                confirmMessage: function (data) {
                                    return l('BacktestHistoryDeletionConfirmationMessage', data.record.id);
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
                title: l('BacktestHistoryMainLeader'),
                data: "mainLeader"
            },
            {
                title: l('BacktestHistoryLeaderChange'),
                data: "leaderChange"
            },
            {
                title: l('BacktestHistoryBuyPrice'),
                data: "buyPrice"
            },
            {
                title: l('BacktestHistorySellPrice'),
                data: "sellPrice"
            },
            {
                title: l('BacktestHistoryTradeDate'),
                data: "tradeDate"
            },
            {
                title: l('BacktestHistoryRateOfReturn'),
                data: "rateOfReturn"
            },
            {
                title: l('BacktestHistoryStrategyId'),
                data: "strategyId"
            },
            {
                title: l('BacktestHistoryFollowStock'),
                data: "followStock"
            },
            {
                title: l('BacktestHistoryNav'),
                data: "nav"
            },
            {
                title: l('BacktestHistorySellType'),
                data: "sellType"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBacktestHistoryButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
