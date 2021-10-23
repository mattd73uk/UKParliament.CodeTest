import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

import { Person } from './../models/person';
import { PersonService } from './../services/person.service';
import { PersonEditComponent } from '../shared/person-edit/person-edit.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  public people: Person[];
  public newPerson: Person = new Person();

  constructor(private personService: PersonService, public dialog: MatDialog) {
    personService.getPeople().subscribe(result => {
      this.people = result;
    }, error => console.error(error));
  }

  editPerson(person: Person): void {
    const dialogRef = this.dialog.open(PersonEditComponent, { data: person, width: '450px' });

    dialogRef.afterClosed().subscribe((p: Person) => {
      this.personService.update(p).subscribe(responsePerson => {
      }, error => console.error(error));
    });
  }

  addPerson(person: Person): void {
    const dialogRef = this.dialog.open(PersonEditComponent, { data: person, width: '450px' });

    dialogRef.afterClosed().subscribe((p: Person) => {
      this.personService.add(p).subscribe(responsePerson => {
        this.people.push(responsePerson);
        this.newPerson = new Person();
      }, error => console.error(error));
    });

  }

  deletePerson(id: number) {

    this.personService.delete(id).subscribe(resultId => {
      this.people = this.people.filter(function (obj) { return obj.id !== resultId });
    }, error => console.error(error));

  }

}
