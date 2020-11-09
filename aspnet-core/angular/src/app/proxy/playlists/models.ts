import type { AuditedEntityDto } from '@abp/ng.core';
import type { AuditedAggregateRoot } from '../volo/abp/domain/entities/auditing/models';

export interface CreateUpdateIncludeDto {
  songId: string;
  playlistId: string;
}

export interface CreateUpdatePlaylistDto {
  userId: string;
  name: string;
}

export interface IncludeDto extends AuditedEntityDto<string> {
  songId: string;
  playlistId: string;
}

export interface Playlist extends AuditedAggregateRoot<string> {
  userId: string;
  name: string;
}

export interface PlaylistDto extends AuditedEntityDto<string> {
  userId: string;
  name: string;
}
