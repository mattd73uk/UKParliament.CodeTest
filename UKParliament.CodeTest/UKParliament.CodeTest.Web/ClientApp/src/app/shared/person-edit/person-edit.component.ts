import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Person } from './../../models/person';

@Component({
  selector: 'app-person-edit',
  templateUrl: './person-edit.component.html',
  styleUrls: ['./person-edit.component.scss']
})
export class PersonEditComponent implements OnInit {

  minDate: Date = new Date();
  maxDate: Date = new Date();
  
  constructor(public dialogRef: MatDialogRef<PersonEditComponent>, @Inject(MAT_DIALOG_DATA) public data: Person) {
    this.minDate.setFullYear(this.minDate.getFullYear() - 150);
  }

  ngOnInit() {
  }

}
