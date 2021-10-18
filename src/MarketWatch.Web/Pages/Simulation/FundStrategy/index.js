$(function () {

    var l = abp.localization.getResource('MarketWatch');

    var service = marketWatch.simulation.fundStrategy;
    var createModal = new abp.ModalManager(abp.appPath + 'Simulation/FundStrategy/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Simulation/FundStrategy/EditModal');

    var dataTable = $('#FundStrategyTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('MarketWatch.FundStrategy.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('MarketWatch.FundStrategy.Delete'),
                                confirmMessage: function (data) {
                                    return l('FundStrategyDeletionConfirmationMessage', data.record.id);
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
                title: l('FundStrategyName'),
                data: "name"
            },
            {
                title: l('FundStrategyInvestTriggerRate'),
                data: "investTriggerRate"
            },
            {
                title: l('FundStrategyAnalysisPeriod'),
                data: "analysisPeriod"
            },
            {
                title: l('FundStrategyPortfolioNumber'),
                data: "portfolioNumber"
            },
            {
                title: l('FundStrategyPriceToUse'),
                data: "priceToUse"
            },
            {
                title: l('FundStrategyLossCutRate'),
                data: "lossCutRate"
            },
            {
                title: l('FundStrategyInvestDate'),
                data: "investDate"
            },
            {
                title: l('FundStrategyInUse'),
                data: "inUse"
            },
            {
                title: l('FundStrategyRatePerInvesmentPeriod'),
                data: "ratePerInvesmentPeriod"
            },
            {
                title: l('FundStrategyRatePerYear'),
                data: "ratePerYear"
            },
            {
                title: l('FundStrategyDaysToTest'),
                data: "daysToTest"
            },
            {
                title: l('FundStrategyStd'),
                data: "std"
            },
            {
                title: l('FundStrategyInvestStartDate'),
                data: "investStartDate"
            },
            {
                title: l('FundStrategyCreatedAt'),
                data: "createdAt"
            },
            {
                title: l('FundStrategyDisabled'),
                data: "disabled"
            },
            {
                title: l('FundStrategyCountryToInvest'),
                data: "countryToInvest"
            },
            {
                title: l('FundStrategyCoefficientAllowed'),
                data: "coefficientAllowed"
            },
            {
                title: l('FundStrategyFundTradeHistory'),
                data: "fundTradeHistory"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewFundStrategyButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
