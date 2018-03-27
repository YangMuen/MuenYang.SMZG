var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('SMZG');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);