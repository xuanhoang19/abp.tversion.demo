import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PackageService {
  apiName = 'Default';


  getList = () =>
    this.restService.request<any, PagedResultDto<any>>({
      method: 'GET',
      url: `/api/Package/getall`,

    },
    { apiName: this.apiName });


  constructor(private restService: RestService) {}
}
