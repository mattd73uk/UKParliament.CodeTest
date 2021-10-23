export class Person {
  id?: number;
  name?: string;
  dateOfBirth?: Date;
  address?: string;
  favouriteIceCream?: string;

  public constructor(init?: Partial<Person>) {
    Object.assign(this, init);
  }

}
