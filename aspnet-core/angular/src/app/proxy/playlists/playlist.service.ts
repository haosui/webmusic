import type { CreateUpdatePlaylistDto, Playlist, PlaylistDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PlaylistService {
  apiName = 'Default';

  create = (input: CreateUpdatePlaylistDto) =>
    this.restService.request<any, PlaylistDto>({
      method: 'POST',
      url: `/api/app/playlist`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/playlist/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, PlaylistDto>({
      method: 'GET',
      url: `/api/app/playlist/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<PlaylistDto>>({
      method: 'GET',
      url: `/api/app/playlist`,
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdatePlaylistDto) =>
    this.restService.request<any, PlaylistDto>({
      method: 'PUT',
      url: `/api/app/playlist/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  getlist = () =>
    this.restService.request<any, Playlist[]>({
      method: 'GET',
      url: `/api/app/playlist/getlist`,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
