import type { CreateUpdateIncludeDto, IncludeDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class IncludeService {
  apiName = 'Default';

  create = (input: CreateUpdateIncludeDto) =>
    this.restService.request<any, IncludeDto>({
      method: 'POST',
      url: `/api/app/include`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/include/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, IncludeDto>({
      method: 'GET',
      url: `/api/app/include/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<IncludeDto>>({
      method: 'GET',
      url: `/api/app/include`,
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateIncludeDto) =>
    this.restService.request<any, IncludeDto>({
      method: 'PUT',
      url: `/api/app/include/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
