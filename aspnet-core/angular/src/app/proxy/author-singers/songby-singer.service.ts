import type { CreateUpdateSongbySingerDto, SongbySingerDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SongbySingerService {
  apiName = 'Default';

  create = (input: CreateUpdateSongbySingerDto) =>
    this.restService.request<any, SongbySingerDto>({
      method: 'POST',
      url: `/api/app/songbySinger`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/songbySinger/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, SongbySingerDto>({
      method: 'GET',
      url: `/api/app/songbySinger/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<SongbySingerDto>>({
      method: 'GET',
      url: `/api/app/songbySinger`,
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateSongbySingerDto) =>
    this.restService.request<any, SongbySingerDto>({
      method: 'PUT',
      url: `/api/app/songbySinger/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
