$(function () {

    var l = abp.localization.getResource('MarketWatch');

    var service = marketWatch.simulation.fundTradeHistory;
    var createModal = new abp.ModalManager(abp.appPath + 'Simulation/FundTradeHistory/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Simulation/FundTradeHistory/EditModal');

    var dataTable = $('#FundTradeHistoryTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
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
                                visible: abp.auth.isGranted('MarketWatch.FundTradeHistory.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('MarketWatch.FundTradeHistory.Delete'),
                                confirmMessage: function (data) {
                                    return l('FundTradeHistoryDeletionConfirmationMessage', data.record.id);
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
                title: l('FundTradeHistoryMainLeader'),
                data: "mainLeader"
            },
            {
                title: l('FundTradeHistoryLeaderChange'),
                data: "leaderChange"
            },
            {
                title: l('FundTradeHistoryBuyPrice'),
                data: "buyPrice"
            },
            {
                title: l('FundTradeHistorySellPrice'),
                data: "sellPrice"
            },
            {
                title: l('FundTradeHistoryTradeDate'),
                data: "tradeDate"
            },
            {
                title: l('FundTradeHistoryRateOfReturn'),
                data: "rateOfReturn"
            },
            {
                title: l('FundTradeHistoryStrategyId'),
                data: "strategyId"
            },
            {
                title: l('FundTradeHistoryFollowStock'),
                data: "followStock"
            },
            {
                title: l('FundTradeHistoryNav'),
                data: "nav"
            },
            {
                title: l('FundTradeHistorySellType'),
                data: "sellType"
            },
            {
                title: l('FundTradeHistoryCoefficient'),
                data: "coefficient"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewFundTradeHistoryButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
