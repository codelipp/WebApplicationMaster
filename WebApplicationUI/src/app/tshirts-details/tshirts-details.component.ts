import { Component, OnInit } from '@angular/core';
import { Tshirt } from '../models/tshirt.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tshirts-details',
  templateUrl: './tshirts-details.component.html',
  styleUrls: ['./tshirts-details.component.css']
})
export class TshirtsDetailsComponent implements OnInit {
  tshirt = new Tshirt();

  constructor(
    private router: Router
  ) { }

  ngOnInit(): void {
    this.tshirt = history.state.tshirtSelected;
  }

  public return() {
    this.router.navigateByUrl('');
  }

  public onTshirtChanged(event: any) {
    this.tshirt = event;
  }
}
