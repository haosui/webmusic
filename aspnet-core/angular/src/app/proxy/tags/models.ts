import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateSongTagDto {
  songId: string;
  tagId: string;
}

export interface CreateUpdateTagDto {
  name: string;
  description: string;
}

export interface SongTagDto extends AuditedEntityDto<string> {
  songId: string;
  tagId: string;
}

export interface TagDto extends AuditedEntityDto<string> {
  name: string;
  description: string;
}
