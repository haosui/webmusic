import type { CreateUpdateSongTagDto, SongTagDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SongTagService {
  apiName = 'Default';

  create = (input: CreateUpdateSongTagDto) =>
    this.restService.request<any, SongTagDto>({
      method: 'POST',
      url: `/api/app/songTag`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/songTag/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, SongTagDto>({
      method: 'GET',
      url: `/api/app/songTag/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<SongTagDto>>({
      method: 'GET',
      url: `/api/app/songTag`,
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateSongTagDto) =>
    this.restService.request<any, SongTagDto>({
      method: 'PUT',
      url: `/api/app/songTag/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
