import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { TshirtImage } from 'src/app/models/tshirt-image.model';
import { Tshirt } from 'src/app/models/tshirt.model';
import { TshirtImageService } from 'src/app/service/tshirt-image.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-images',
  templateUrl: './images.component.html',
  styleUrls: ['./images.component.css']
})
export class ImagesComponent implements OnInit {
  @Input() tshirt = new Tshirt();
  @Input() colorId: any;
  @Input() fabricId: any;
  @Output() tshirtChange = new EventEmitter<any>();

  tshirtImages: Array<TshirtImage> | undefined;
  url = `${environment.apiUrl}/tshirt-images/`;
  file: any;

  constructor(
    private tshirtImageService: TshirtImageService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.tshirtImages = this.tshirt?.tshirtImages?.filter(t => t.colorId === this.colorId && t.fabricId === this.fabricId);
  }

  public deleteImage(tshirtImageId: any) {
    this.tshirtImageService.delete(tshirtImageId).subscribe((tshirt) => {
      if (tshirt) {
        this.tshirtChange.emit(tshirt);
      }
    });
  }

  public uploadImage(event: any) {
    this.file = event.target.files[0];

    this.tshirtImageService
      .upload(this.file, this.tshirt.id, this.colorId, this.fabricId)
      .subscribe((ok) => {
        if (ok) {
          this.router.navigateByUrl('');
        }
      });
  }

}
