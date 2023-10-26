import { Component, OnInit } from '@angular/core';
import { Tshirt } from '../models/tshirt.model';
import { TshirtService } from '../service/tshirt.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tshirts-list',
  templateUrl: './tshirts-list.component.html',
  styleUrls: ['./tshirts-list.component.css']
})
export class TshirtsListComponent implements OnInit {

  tshirts: Array<Tshirt> = [];

  constructor(
    private tshirtService: TshirtService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.get();
  }

  private get() {
    this.tshirtService.get().subscribe((tshirts) => {
      if (tshirts) this.tshirts = tshirts;
    })
  }

  public details(tshirt: any) {
    this.router.navigateByUrl('/details', {
      state: { tshirtSelected: tshirt }
    });
  }

}
