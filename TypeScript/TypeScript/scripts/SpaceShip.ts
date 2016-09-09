class SpaceShip {

    engine: string;
    crew: number = 105;
    civilians: number = 430;

    get people(): number {
        return this.addNumbers(this.crew,this.civilians);
    }

  constructor(engine: string) {
      this.engine = engine;
  }

  start(): void {
      this.broadCast(this.engine + " engine started.");
  }

  stop():void {
      this.broadCast(this.engine + " engine stopped.");
  }

  private addNumbers(n1: number, n2: number): number {
      var result:number  = n1 + n2;
      return result;
  }

  broadCast(msg: string): void {
      alert(msg);
  }

}


window.onload = function ():void {
  var enterprise: SpaceShip = new SpaceShip("Impulse");
  enterprise.start();
  enterprise.stop();
  enterprise.broadCast("The enterprise has "+ enterprise.people + " people on board.");

};