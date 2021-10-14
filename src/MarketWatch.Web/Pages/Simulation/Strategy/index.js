$(function () {

    var l = abp.localization.getResource('MarketWatch');

    var service = marketWatch.simulation.strategy;
    var createModal = new abp.ModalManager(abp.appPath + 'Simulation/Strategy/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Simulation/Strategy/EditModal');

    var dataTable = $('#StrategyTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('MarketWatch.Strategy.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('MarketWatch.Strategy.Delete'),
                                confirmMessage: function (data) {
                                    return l('StrategyDeletionConfirmationMessage', data.record.id);
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
                title: l('StrategyInvestTriggerRate'),
                data: "investTriggerRate"
            },
            {
                title: l('StrategyAnalysisPeriod'),
                data: "analysisPeriod"
            },
            {
                title: l('StrategyPortfolioNumber'),
                data: "portfolioNumber"
            },
            {
                title: l('StrategyPriceToUse'),
                data: "priceToUse"
            },
            {
                title: l('StrategyLossCutRate'),
                data: "lossCutRate"
            },
            {
                title: l('StrategyInvestDate'),
                data: "investDate"
            },
            {
                title: l('StrategyInUse'),
                data: "inUse"
            },
            {
                title: l('StrategyRatePerInvesmentPeriod'),
                data: "ratePerInvesmentPeriod"
            },
            {
                title: l('StrategyRatePerYear'),
                data: "ratePerYear"
            },
            {
                title: l('StrategyDaysToTest'),
                data: "daysToTest"
            },
            {
                title: l('StrategyStd'),
                data: "std"
            },
            {
                title: l('StrategyInvestStartDate'),
                data: "investStartDate"
            },
            {
                title: l('StrategyCountryToInvest'),
                data: "countryToInvest"
            },
            {
                title: l('StrategyCreatedAt'),
                data: "createdAt"
            },
            {
                title: l('StrategyDisabled'),
                data: "disabled"
            },
            {
                title: l('StrategyCoefficientAllowed'),
                data: "coefficientAllowed"
            },
            {
                title: l('StrategyBacktestHistories'),
                data: "backtestHistories"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewStrategyButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
