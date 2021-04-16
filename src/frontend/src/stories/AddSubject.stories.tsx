import { Meta, Story } from "@storybook/react/types-6-0";
import AddSubject from "../components/AddSubject";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/AddSubject",
    decorators: [StoryRouter()],
    components: AddSubject,
} as Meta;

const Template: Story = () => <AddSubject />;

export const Default = Template.bind({});