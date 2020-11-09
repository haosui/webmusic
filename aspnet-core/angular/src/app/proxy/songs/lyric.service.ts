import type { CreateUpdateLyricDto, LyricDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class LyricService {
  apiName = 'Default';

  create = (input: CreateUpdateLyricDto) =>
    this.restService.request<any, LyricDto>({
      method: 'POST',
      url: `/api/app/lyric`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/lyric/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, LyricDto>({
      method: 'GET',
      url: `/api/app/lyric/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<LyricDto>>({
      method: 'GET',
      url: `/api/app/lyric`,
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateLyricDto) =>
    this.restService.request<any, LyricDto>({
      method: 'PUT',
      url: `/api/app/lyric/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
