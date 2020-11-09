import type { CreateUpdateSingerDto, SingerDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SingerService {
  apiName = 'Default';

  create = (input: CreateUpdateSingerDto) =>
    this.restService.request<any, SingerDto>({
      method: 'POST',
      url: `/api/app/singer`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/singer/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, SingerDto>({
      method: 'GET',
      url: `/api/app/singer/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<SingerDto>>({
      method: 'GET',
      url: `/api/app/singer`,
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateSingerDto) =>
    this.restService.request<any, SingerDto>({
      method: 'PUT',
      url: `/api/app/singer/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
