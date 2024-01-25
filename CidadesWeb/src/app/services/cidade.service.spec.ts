/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { cidadeService } from './../services/cidade.service';

describe('Service: Cidade.service', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [cidadeService]
    });
  });

  it('should ...', inject([cidadeService], (service: cidadeService) => {
    expect(service).toBeTruthy();
  }));
});
