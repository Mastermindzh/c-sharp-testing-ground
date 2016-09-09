var SpaceShip = (function () {
    function SpaceShip(engine) {
        this.crew = 105;
        this.civilians = 430;
        this.engine = engine;
    }
    Object.defineProperty(SpaceShip.prototype, "people", {
        get: function () {
            return this.addNumbers(this.crew, this.civilians);
        },
        enumerable: true,
        configurable: true
    });
    SpaceShip.prototype.start = function () {
        this.broadCast(this.engine + " engine started.");
    };
    SpaceShip.prototype.stop = function () {
        this.broadCast(this.engine + " engine stopped.");
    };
    SpaceShip.prototype.addNumbers = function (n1, n2) {
        var result = n1 + n2;
        return result;
    };
    SpaceShip.prototype.broadCast = function (msg) {
        alert(msg);
    };
    return SpaceShip;
}());
window.onload = function () {
    var enterprise = new SpaceShip("Impulse");
    enterprise.start();
    enterprise.stop();
    enterprise.broadCast("The enterprise has " + enterprise.people + " people on board.");
};
