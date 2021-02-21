import { Component, OnInit } from '@angular/core';
import { PackageService } from '../shared/services/backage.service';

@Component({
  selector: 'app-changelogs',
  templateUrl: './changelogs.component.html',
  styleUrls: ['./changelogs.component.scss']
})
export class ChangelogsComponent implements OnInit {

  constructor(private packageService: PackageService) { }

  ngOnInit(): void {
    this.packageService.getList().subscribe((res: any) => {
      console.log(res);
    })
  }

}
