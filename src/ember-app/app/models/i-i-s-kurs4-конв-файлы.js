import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as КонвФайлыMixin
} from '../mixins/regenerated/models/i-i-s-kurs4-конв-файлы';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(КонвФайлыMixin, Validations, {
});

defineProjections(Model);

export default Model;
