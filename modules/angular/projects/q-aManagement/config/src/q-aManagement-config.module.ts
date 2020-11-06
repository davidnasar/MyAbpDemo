import { ModuleWithProviders, NgModule } from '@angular/core';
import { QA_MANAGEMENT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class QAManagementConfigModule {
  static forRoot(): ModuleWithProviders<QAManagementConfigModule> {
    return {
      ngModule: QAManagementConfigModule,
      providers: [QA_MANAGEMENT_ROUTE_PROVIDERS],
    };
  }
}
